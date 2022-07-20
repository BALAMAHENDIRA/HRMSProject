using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSProject.Repository.Models
{
    public partial class Rental
    {
        public int ReservationNumber { get; set; }
        public string Amount { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Vin { get; set; }
        public int CustomerId { get; set; }
        public int PickUpLocation { get; set; }
        public int ReturnLocation { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Location PickUpLocationNavigation { get; set; }
        public virtual Location ReturnLocationNavigation { get; set; }
        public virtual Car VinNavigation { get; set; }
    }
}
