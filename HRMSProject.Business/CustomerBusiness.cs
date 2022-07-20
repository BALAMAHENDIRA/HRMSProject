using AutoMapper;
using HRMSProject.Business.Interfaces;
using HRMSProject.Models;
using HRMSProject.Repository.Interfaces;
using HRMSProject.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository _customerRepository;

        private readonly IMapper _mapper;

        public CustomerBusiness(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public List<CustomerVM> AddCustomers()
        {
            throw new NotImplementedException();
        }

         

        public async Task<List<CustomerVM>> GetCustomers()
        {
            List<Customer> list = await _customerRepository.GetCustomers();
            return _mapper.Map<List<CustomerVM>>(list);

        }

        public CustomerVM AddCustomers(CustomerVM cus)
        {
            var result = _customerRepository.AddCustomers(_mapper.Map<Customer>(cus));
            return _mapper.Map<CustomerVM>(result);
        }

        public async Task<List<CarCatVM>> GetCarbyID(int? Id)
        {
            var list = await _customerRepository.GetCarbyID(Id);
            return _mapper.Map<List<CarCatVM>>(list);
        }


        public async Task<List<CarVM>> GetAllCars()
        {
            var list = await _customerRepository.GetAllCars();
            return _mapper.Map<List<CarVM>>(list);
        }

        public CarVM AddCars(CarVM cus)
        {
            var result = _customerRepository.AddCars(_mapper.Map<Car>(cus));
            return _mapper.Map<CarVM>(result);
        }


        public CarVM UpdateCars(int Vin)
        {

            var result = _customerRepository.UpdateCars(Vin);
            return _mapper.Map<CarVM>(result);
        }

        public bool UpdateCars( CarVM cus)
        {
             
            var result = _customerRepository.UpdateCars(_mapper.Map<Car>(cus));
            return result;
        }

        public CarVM Delete(int Vin)
        {
            var result = _customerRepository.Delete(Vin);
            return _mapper.Map<CarVM>(result);
        }

    }
}
