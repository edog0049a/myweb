using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myweb.Models
{
    public class Address
    {
       public int AddressId { get; set; }
       public string Name { get; set; }
       public string Street { get; set; }
       public string Street2 { get; set; }
       public string State { get; set; }
       public int ZipCode { get; set; }       
    }
}