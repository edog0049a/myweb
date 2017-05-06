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
        public string LoginKey { get; set; } = null;
        private string Password { get; set; }
        

    }
}