using StudentRecord.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Models
{
    public class Grade : ActiveEntity
    {
        public int CourseId { get; set; }
        [Required]
        public virtual Course Course { get; set; }
        public int StudentId { get; set; }
        [Required]
        public virtual IStudent Student { get; set; }
        public string Value { get; set; }

        public static IQueryable<Grade> ForStudentCourse(int courseId, int studentId)
        {
            return from grades in _ACTIVE_CONTEXT.Grades
                  where grades.CourseId == courseId && grades.StudentId == studentId
                  select grades;
        }
    }
}