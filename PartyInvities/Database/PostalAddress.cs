//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PartyInvities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostalAddress
    {
        public short Id { get; set; }
        public string StreetNumberAndName { get; set; }
        public string Unit { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
    
        public virtual RentalProperty RentalProperty { get; set; }
    }
}