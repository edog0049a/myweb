using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myweb.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public Name Name { get; set; }
        public Profile Profile { get; set; }
        public User User { get; set; }


    }
}