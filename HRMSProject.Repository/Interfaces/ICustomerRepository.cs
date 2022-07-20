using HRMSProject.Repository.Models;
using HRMSProject.Repository.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Repository.Interfaces
{
   public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
         Customer AddCustomers(Customer cus);
        Task<List<CarCat>> GetCarbyID(int? Id);
        Task<List<Car>> GetAllCars();


        Car AddCars(Car cus);


        Car UpdateCars(int Vin);
        bool UpdateCars( Car cus);

        Car Delete(int Vin);


    }
}
