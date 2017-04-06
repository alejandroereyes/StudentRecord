using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentRecordApp.Web.Models
{
    public class Student : ApplicationUser
    {
        public string Type { get; set; }
    }
}

