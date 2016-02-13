using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvities.Models;

namespace PartyInvities.Controllers
{
    public class OakGroveController : Controller
    {
        // GET: OakGrove
        public ViewResult Index()
        {
            //RentalProperty rentalProperty = new RentalProperty { 
            //    Name = "Oak Grove Crossing",
            //    ShortDescription = "Clean, Cozy, Quiet Condo for Rent",
            //    Address = new PostalAddress { 
            //        StreetNumberAndName="3473 Forestdate Dr.", 
            //        City = "Burlington", 
            //        Unit = "1C", 
            //        ZipCode = "27215" 
            //    }, 
            //    MonthlyHOAFee = 130,  
            //    YearBuilt = 2003 };

            RentalProperty rentalProperty = new RentalProperty(
                2,
                "Oak Grove Crossing",
                "Clean, Cozy, Quiet Condo for Rent",
                1,
                new PostalAddress
                {
                    StreetNumberAndName = "3473 Forestdate Dr.",
                    City = "Burlington",
                    Unit = "1C",
                    ZipCode = 27215
                },
                2003,
                130
            );

            return View(rentalProperty);
        }

        public RedirectToRouteResult Away()
        {
            return RedirectToAction("RsvpForm", "Home");
        }
    }
}