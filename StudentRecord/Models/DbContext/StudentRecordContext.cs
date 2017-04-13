using StudentRecord.Models.Accounts;
using System.Data.Entity;

namespace StudentRecord.Models.DbContext
{
    public class StudentRecordContext : System.Data.Entity.DbContext
    {
        public StudentRecordContext()
            : base("DefaultConnection")
        {
        }
        public IDbSet<Account> Accounts { get; set; }
        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<AccountType> AccountTypes { get; set; }
        public IDbSet<Credit> Credits { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Grade> Grades { get; set; }

        public static StudentRecordContext Create()
        {
            return new StudentRecordContext();
        }
    }

}