using StudentRecord.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace StudentRecord.Models.Accounts
{
    public class Undergraduate : Account, IStudent
    {
        public Undergraduate() : base(AccountType.Undergraduate().Id)
        {
        }

        public IDbSet<Grade> Grades { get; set; }

        public bool BuyCafeteriaCredit(decimal amount)
        {
            return "action to buy credits suceeded".Length > 0 ? true : false;
        }

        public bool RegisterForClass(int courseId)
        {
            return "action to sign up for class succeded".Length > 0 ? true : false;
        }

        public IQueryable<StudentCourseDetail> GetTranscript()
        {
            Transcript transcript = new Transcript(this, Courses);
            return transcript.Build();
        }
    }
}