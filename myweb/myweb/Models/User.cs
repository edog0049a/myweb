using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myweb.Models
{
    public class User
    {
        private bool IsLoginedIn { get; set; }
        public string UserName { get; set; }
        public enum UserLevel
        {

        }
        public string LoginKey { get; set; } = null;
    }
}