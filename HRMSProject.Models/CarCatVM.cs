using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Models
{
   public class CarCatVM
    {

        public string Model { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int? Car_Seats { get; set; }

        public int cat_id { get; set; }
        public string category_name { get; set; }
    }
}
