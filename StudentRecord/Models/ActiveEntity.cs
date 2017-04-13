using StudentRecord.Models.DbContext;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRecord.Models
{
    public abstract class ActiveEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
        [NotMapped]
        public static StudentRecordContext _ACTIVE_CONTEXT = new StudentRecordContext();
        [NotMapped]
        public StudentRecordContext _activeContext
        {
            get { return _ACTIVE_CONTEXT; }    
        }
    }
}