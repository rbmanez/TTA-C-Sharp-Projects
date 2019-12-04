using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.ViewModels
{
    //a view model class for the data that you need to pass to the view
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}