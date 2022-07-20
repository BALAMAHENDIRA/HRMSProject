using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSProject.Repository.Models
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int Vin { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int? CarSeats { get; set; }
        public string CarType { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
