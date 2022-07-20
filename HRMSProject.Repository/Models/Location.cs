using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSProject.Repository.Models
{
    public partial class Location
    {
        public Location()
        {
            RentalPickUpLocationNavigations = new HashSet<Rental>();
            RentalReturnLocationNavigations = new HashSet<Rental>();
        }

        public int LocationId { get; set; }
        public string Street { get; set; }
        public int? StreetNumber { get; set; }
        public string City { get; set; }

        public virtual ICollection<Rental> RentalPickUpLocationNavigations { get; set; }
        public virtual ICollection<Rental> RentalReturnLocationNavigations { get; set; }
    }
}
