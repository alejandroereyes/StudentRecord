using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace StudentRecord.Models.Accounts
{
    public class Account : ActiveEntity
    {
        public Account(int accountId)
        {
            AccountId = accountId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual int AccountId { get; set; }
        public virtual AccountType AccountType { get; set; }
        
        public virtual Address Address { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public string UserName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}