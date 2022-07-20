using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Models
{
   public class CustomerVM
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage ="Customer Id is mandatory")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
    }
}
