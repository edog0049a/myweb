using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myweb.Models
{
	public class Profile
	{
        public int Id { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
    }
}