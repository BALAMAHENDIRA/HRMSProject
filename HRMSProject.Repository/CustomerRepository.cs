using HRMSProject.Repository.Interfaces;
using HRMSProject.Repository.Models;
using HRMSProject.Repository.View_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Repository
{
   public class CustomerRepository : ICustomerRepository
    {
        private readonly mycontext _context;

        public CustomerRepository(mycontext context)
        {
            _context = context;
        }

        

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public Customer AddCustomers(Customer cus)
        {
           var result =  _context.Customers.Add(cus);
            _context.SaveChanges();
            return result.Entity;
        }

        public async Task<List<CarCat>> GetCarbyID(int? Id)
        {
            var result = await _context.CarCats.FromSqlRaw("exec GetCarbyID {0}", Id).ToListAsync();
            return result;
        }

       


        //CREATE
        
        public Car AddCars(Car cus)
        {
            var result = _context.Cars.Add(cus);
            _context.SaveChanges();
            return result.Entity;
        }

        //READ

        public async Task<List<Car>> GetAllCars()
        {
            List<Car> list = _context.Cars
                            .OrderBy(c => c.Vin)
                            .ToList();
            return list;
        }

        //UPDATE
        
        public Car UpdateCars(int Vin)
        {
            var cus = _context.Cars.Find(Vin);
            return cus;
        }
       
        public bool UpdateCars(Car cus)
        {
            bool status;
            
            try
            {
                var student = _context.Cars.Where(s => s.Vin == cus.Vin).FirstOrDefault();
                _context.Cars.Remove(student);
               _context.Cars.Add(cus);
                _context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
                   
           
            return status; 
        }

        public Car Delete(int Vin)
        {
            var cus = _context.Cars.Where(x => x.Vin == Vin).SingleOrDefault();
            var result = _context.Cars.Remove(cus);
            _context.SaveChanges();
            return result.Entity;
        }
    }
}
