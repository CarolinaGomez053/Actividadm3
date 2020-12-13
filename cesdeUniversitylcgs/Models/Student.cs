using System;
using System.Collections.Generic;

namespace CesdeUniversitylcgs.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public string FirstMidName { get; internal set; }
    }
}