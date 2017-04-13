using StudentRecord.Models.Accounts;
using System.ComponentModel.DataAnnotations;

namespace StudentRecord.Models
{
    public class Address : ActiveEntity
    {
        public int AccountId { get; set; }

        [Required]
        public virtual Account Account { get; set; }

        public string Street { get; set; }
        public string Unit { get; set; }

        [MaxLength(2, ErrorMessage = "State must be 2 characters long."), MinLength(2, ErrorMessage = "State must be 2 characters long.")]
        public string State { get; set; }

        public int ZipCode { get; set; }
    }
}