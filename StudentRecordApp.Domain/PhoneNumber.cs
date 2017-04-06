using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordApp.Domain
{
    public class PhoneNumber
    {
        public int      Id        { get; set; }
        public int      UserId    { get; set; }
        public User     User      { get; set; } 
        public int      AreaCode  { get; set; }
        public int      Prefix    { get; set; }
        public int      Suffix    { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public override string ToString()
        {
            return $"{AreaCode}-{Prefix}-{Suffix}";
        }
    }
}
