using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Models
{
   public class CarVM
    {
        public int Vin { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int CarSeats { get; set; }
        public string CarType { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public int CategoryId { get; set; }
    }
}
