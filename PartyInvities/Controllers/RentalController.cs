﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvities.Models;

namespace PartyInvities.Controllers
{
    public class RentalController : Controller
    {
		private RentalProperty[] propertyData =
		{
			new RentalProperty(
				1, "Shadowood",
				"Spacious Condo in Historic District for Rent",
				1,
				new PostalAddress
				{
					StreetNumberAndName = "625 W Front St.",
					City = "Burlington",
					Unit = "#C",
					ZipCode = 27215
				},
				1980, 90, BuildingType.Condo
			),
			new RentalProperty(
				2, "Oak Grove Crossing",
				"Clean, Cozy, Quiet Condo for Rent",
				1,
				new PostalAddress
				{
					StreetNumberAndName = "3473 Forestdate Dr.",
					City = "Burlington",
					Unit = "1C",
					ZipCode = 27215
				},
				2003, 130, BuildingType.Townhome
			)
		};

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

		public ActionResult GetProperties()
		{
			return View(propertyData);
		}

		[HttpPost]
		public ActionResult GetProperties(string selectedBuilding)
		{
			if (selectedBuilding == "All" || string.IsNullOrEmpty(selectedBuilding))
			{
				return View(propertyData);
			} else
			{
				BuildingType selected = (BuildingType)Enum.Parse(typeof(BuildingType), selectedBuilding);
				return View(propertyData.Where(p => p.Building == selected));
			}

		}

	}
}