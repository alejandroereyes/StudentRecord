using System.Collections.Generic;

namespace StudentRecordApp.Domain
{
    public class Student : User
    {
        public Student()
        {
            Type = "Student";
        }
        public List<Course> Courses { get; set; }
        public List<Credit> Credits { get; set; }
    }
}