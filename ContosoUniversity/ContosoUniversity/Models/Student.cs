using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //The ID property will become the primary key. By default, Entity Framework
        //interprets a property that's named ID or classname ID as the primary key.
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //Navigation properties hold other entities that are related to this entity. In this case, the Enrollments property
        //of a Student entity will hold all of the Enrollment entities that are related to that Student entity.
        //Navigation properties are typically defined as virtual so that they can take advantage of certain Entity Framework functionality such as lazy loading.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}