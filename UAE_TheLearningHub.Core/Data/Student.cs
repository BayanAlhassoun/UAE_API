using System;
using System.Collections.Generic;

namespace UAE_TheLearningHub.Core.Data
{
    public partial class Student
    {
        public Student()
        {
            Logins = new HashSet<Login>();
            StdCourses = new HashSet<StdCourse>();
        }

        public decimal Studentid { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? Dateofbirth { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<StdCourse> StdCourses { get; set; }
    }
}
