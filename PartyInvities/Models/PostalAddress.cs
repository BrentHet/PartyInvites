using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvities.Models
{
    public class PostalAddress
    {
        public string StreetNumberAndName { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    }
}