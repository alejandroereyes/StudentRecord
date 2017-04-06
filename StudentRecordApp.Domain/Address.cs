using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordApp.Domain
{
    public class Address
    {
        public int      Id        { get; set; }
        public int      UserId    { get; set; }
        public User     User      { get; set; }
        public string   Street    { get; set; }
        public string   Unit      { get; set; }
        public string   City      { get; set; }
        public string   State     { get; set; }
        public int      ZipCode   { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
