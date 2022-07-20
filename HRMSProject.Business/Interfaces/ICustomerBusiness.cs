using HRMSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Business.Interfaces
{
    public interface ICustomerBusiness
    {
        Task<List<CustomerVM>> GetCustomers();
        CustomerVM AddCustomers(CustomerVM cus);

        Task<List<CarCatVM>> GetCarbyID(int? Id);


        Task<List<CarVM>> GetAllCars();

        CarVM AddCars(CarVM cus);

        CarVM UpdateCars(int Vin);
        bool UpdateCars(CarVM cus);

        CarVM Delete(int Vin);
    }


}
