using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myweb.Models
{
    public class User
    {
        public int Id { get; set; }
        private bool IsLoginedIn { get; set; }
        public string UserName { get; set; }
        private string LoginKey { get; set; } = null;
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}