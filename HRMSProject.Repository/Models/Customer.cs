using System;
using System.Collections.Generic;

#nullable disable

namespace HRMSProject.Repository.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
