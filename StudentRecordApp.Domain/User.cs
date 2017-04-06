using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordApp.Domain
{
    public class User
    {
        public int      Id        { get; set; }
        public string   FirstName { get; set; }
        public string   LastName  { get; set; }
        public string   Type      { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
