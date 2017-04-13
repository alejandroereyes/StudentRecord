using StudentRecord.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Interfaces
{
    public interface IStudent
    {
        IDbSet<Grade> Grades { get; set; }
        int Id { get; }

        bool BuyCafeteriaCredit(decimal amount);

        bool RegisterForClass(int courseId);

        IQueryable<StudentCourseDetail> GetTranscript();
    }
}