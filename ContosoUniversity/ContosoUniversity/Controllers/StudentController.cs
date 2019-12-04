//PURPOSE:    Microsoft tutorial for code first with entity framework and mvc
//AUTHOR:     Robert Manez

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using PagedList;

namespace ContosoUniversity.Controllers
{
    //the scaffolder creates a StudentController.cs file and a set of views (.cshtml files) that work with the controller. In the future when you create projects that use Entity Framework, you can also take advantage of some additional functionality of the scaffolder:
    //create your first model class, don't create a connection string, and then in the Add Controller box specify New data context by selecting the + button next to Data context class. The scaffolder will create your DbContext class and your connection string as well as the controller and views.

    //The process of requesting the data automatically triggers the creation of the database.
    public class StudentController : Controller
    {
        //a class variable has been created that instantiates a database context object
        private SchoolContext db = new SchoolContext();

        // GET: Student
        //receives a sortOrder parameter from the query string in the URL. The parameter is a string that's either "Name" or "Date", optionally followed by an underscore and the string "desc" to specify descending order. The default sort order is ascending.
        //The searchString value is received from a text box that you'll add to the Index view.
        //
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            //A ViewBag property provides the view with the current sort order, because this must be included in the paging links in order to keep the sort order the same while paging
            ViewBag.CurrentSort = sortOrder;
            //The two ViewBag variables are used so that the view can configure the column heading hyperlinks with the appropriate query string values.
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            // provides the view with the current filter string.
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var students = from s in db.Students
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstMidName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.LastName);
                    break;
                case "Date":
                    students = students.OrderBy(s => s.EnrollmentDate);
                    break;
                case "date_desc":
                    students = students.OrderByDescending(s => s.EnrollmentDate);
                    break;
                default:
                    students = students.OrderBy(s => s.LastName);
                    break;
            }
            //the ToPagedList extension method on the students IQueryable object converts the student query to a single page of students in a collection type that supports paging. That single page of students is then passed to the view
            int pageSize = 3;
            //The two question marks represent the null-coalescing operator, which defines a default value for a nullable type
            //return the value of page if it has a value, or return 1 if page is null.
            int pageNumber = (page ?? 1);
            return View(students.ToPagedList(pageNumber, pageSize));
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //the action method for the Details view uses the Find method to retrieve a single Student entity.
            //The key value is passed to the method as the id parameter and comes from route data in the Details hyperlink on the Index page.
            //The URLs are created by ActionLink statements in the Razor view.
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //The ValidateAntiForgeryToken attribute helps prevent cross-site request forgery attacks. It requires a corresponding Html.AntiForgeryToken() statement in the view
        [ValidateAntiForgeryToken]
        //The Bind attribute is one way to protect against over-posting in create scenarios.
        //It's best to use the Include parameter with the Bind attribute to whitelist fields.
        //An alternative way to prevent overposting that is preferred by many developers is to use view models rather than entity classes with model binding.
        public ActionResult Create([Bind(Include = "LastName, FirstMidName, EnrollmentDate")] Student student)
        {
            //This code adds the Student entity created by the ASP.NET MVC model binder to the Students entity set and then saves the changes to the database.
            //Model binder refers to the ASP.NET MVC functionality that makes it easier for you to work with data submitted by a form; a model binder converts posted form values to CLR types and passes them to the action method in parameters.
            //In this case, the model binder instantiates a Student entity for you using property values from the Form collection.
            try
            {
                if (ModelState.IsValid)
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult EditPost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var studentToUpdate = db.Students.Find(id);
            //calls TryUpdateModel to update fields from user input in the posted form data.
            //To prevent overposting, the fields that you want to be updateable by the Edit page are whitelisted in the TryUpdateModel parameters.
            if (TryUpdateModel(studentToUpdate, "",
               new string[] { "LastName", "FirstMidName", "EnrollmentDate" }))
            {
                try
                {
                    //When the SaveChanges method is called, the Modified flag causes the Entity Framework to create SQL statements to update the database row.
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(studentToUpdate);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            //uses the Find method to retrieve the selected Student entity, as you saw in the Details and Edit methods.
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        //The CLR requires overloaded methods to have different method parameters.
        //Now that the signatures are unique, you can stick with the MVC convention and use the same name for the HttpPost and HttpGet delete methods.
        public ActionResult Delete(int id)
        {
            //handle any errors that might occur when the database is updated.
            try
            {
                //retrieves the selected entity, then calls the Remove method to set the entity's status to Deleted.
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                //When SaveChanges is called, a SQL DELETE command is generated.
                db.SaveChanges();
            }
            //calls the HttpGetAttribute Delete method, passing it a parameter that indicates that an error has occurred.
            //The HttpGetAttribute Delete method then redisplays the confirmation page along with the error message, giving the user an opportunity to cancel or try again.
            catch (DataException/* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
