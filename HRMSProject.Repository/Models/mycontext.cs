using HRMSProject.Repository.View_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace HRMSProject.Repository.Models
{
    public class mycontext : carRentalContext
    {
        public mycontext()
        {
        }

        public mycontext(DbContextOptions<carRentalContext> options)
               : base(options)
        {
        }

        public virtual DbSet<CarCat> CarCats { get; set; }
         


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarCat>(x => x.HasNoKey());
        }
    }
}
