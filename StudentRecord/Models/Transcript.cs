using StudentRecord.Interfaces;
using StudentRecord.Models.DbContext;
using System;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Models
{
    public struct StudentCourseDetail
    {
        public Course Course;
        public IStudent Student;
        public DateTime StartDate;
        public Grade Grade;

        public StudentCourseDetail(Course course, IStudent student)
        {
            Course = course;
            Student = student;
            StartDate = course.StartDate;
            Grade = course.GradeForStudent(student.Id);
        }
    }

    public class Transcript
    {
        public Transcript(IStudent student, IDbSet<Course> courses)
        {
            Student = student;
            Courses = courses;
        }

        private IStudent Student { get; set; }
        private IDbSet<Course> Courses { get; set; }

        public IQueryable<StudentCourseDetail> Build()
        {
            return Courses.Select(
                 course => new StudentCourseDetail(course, Student)
           );
        }

        private StudentRecordContext _activeContext = new StudentRecordContext();
    }
}