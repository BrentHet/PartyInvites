using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvities.Models;

namespace PartyInvities.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult ListByID(int ID)
		{
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
				130,
				BuildingType.Condo
			);

			return View(rentalProperty);
		}

		public ActionResult Edit(int ID)
		{
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
				130,
				BuildingType.Condo
			);

			return View(rentalProperty);
		}

		[HttpPost]
		public ActionResult Edit(RentalProperty rentalProperty)
		{
			return View(rentalProperty);
		}
	}
}