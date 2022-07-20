using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSProject.Models;

using HRMSProject.Repository.Models;
using HRMSProject.Repository.View_Model;

namespace HRMSProject.Utilities
{
    public class AutoMappingConfig : Profile
    {
        public AutoMappingConfig()
        {
            CreateMap<Customer, CustomerVM>().ReverseMap();
            CreateMap<CarCat, CarCatVM>().ReverseMap();
            CreateMap<Car, CarVM>().ReverseMap();

        }
    }
}
