using StudentRecord.Models.Accounts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecord.Models
{
    public class Credit : ActiveEntity
    {
        public int AccountId { get; set; }
        [Required]
        public virtual Account Account { get; set; }
        public string CreditType { get; set; }
        public decimal Amount { get; set; }
    }
}