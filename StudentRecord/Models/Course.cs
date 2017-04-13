using StudentRecord.Models.Accounts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Models
{
    public class Course : ActiveEntity
    {
        public int AccountId { get; set; }
        [Required]
        public virtual IDbSet<Account> Accounts { get; set; }
        public virtual IDbSet<Grade> Grades { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        public Grade GradeForStudent(int studentId)
        {
            return Grades.Where(grade => grade.StudentId == studentId).FirstOrDefault();
        }
    }
}