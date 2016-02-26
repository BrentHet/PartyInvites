using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvities.Models
{
    public partial class RentalProperty
    {
        //public string Name { get; set; }
        //public string ShortDescription { get; set; }
        //public PostalAddress Address;
        //public int YearBuilt { get; set; }
        //public decimal? MonthlyHOAFee { get; set; }

        //readonly string _name;
        //readonly string _shortDescription;
        //readonly PostalAddress _address;
        //readonly int _yearBuilt;
        //readonly decimal? _monthlyHOAFee;

        private int _id;
        private string _name;
        private string _shortDescription;
        private int _addressID;
        private PostalAddress _address;
        private int _yearBuilt;
        private decimal? _monthlyHOAFee;
		private BuildingType _buildingType;

        [Key]
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } }

		[Display(Name = "Description")]
        public string ShortDescription { get { return _shortDescription; } }
        public int AddressID { get { return _addressID; } }
        public PostalAddress Address { get { return _address; } }
        public int YearBuilt { get { return _yearBuilt; } }
        public decimal? MonthlyHOAFee { get { return _monthlyHOAFee; } }
		public BuildingType Building {  get { return _buildingType;  } }

        public RentalProperty(int id, string name, string shortDescription, int addressID, 
			PostalAddress address, int yearBuilt, decimal? monthlyHOAFee, BuildingType buildingType)
        {
            //this.Name = name;
            //this.ShortDescription = shortDescription;
            //this.Address = address;
            //this.YearBuilt = yearBuilt;
            //this.MonthlyHOAFee = monthlyHOAFee;

            _id = id;
            _name = name;
            _shortDescription = shortDescription;
            _addressID = addressID;
            _address = address;
            _yearBuilt = yearBuilt;
            _monthlyHOAFee = monthlyHOAFee;
			_buildingType = buildingType;
        }
    }

	public enum BuildingType
	{
		Condo = 1,
		Townhome = 2,
		Duplex = 3,
		MultiUnit = 4,
	}

}