using HRMSProject.Business.Interfaces;
using HRMSProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRMSProject.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICustomerBusiness _customerBusiness;

        public HomeController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }

        public async Task<IActionResult> Index()
        {
           List<CustomerVM> cust = await _customerBusiness.GetCustomers();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Errormsg()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerVM cus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = _customerBusiness.AddCustomers(cus);
            return View(result);
        }



        public async Task<IActionResult> GetCarbyID(int? Id)
        {
            var result = await _customerBusiness.GetCarbyID(Id);
            return View(result);
        }


        public async Task<ActionResult> GetAllCars()
        {
            List<CarVM> result = await _customerBusiness.GetAllCars();
            return View(result);
        }

         
        [HttpGet]
        public IActionResult AddCars()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCars(CarVM cus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
             _customerBusiness.AddCars(cus);
            return RedirectToAction("GetAllCars");
        }

       [HttpGet]
        public IActionResult UpdateCars(int Vin)
        {

            
            CarVM cus =   _customerBusiness.UpdateCars(Vin);
            return View(cus);
            /* return RedirectToAction("UpdateCars", "Home", new { Vin = cus });*/
        }

        [HttpPost]
        public IActionResult UpdateCars(CarVM cus)
        {
           
          
           bool status = _customerBusiness.UpdateCars(cus);
            if (status)
            {
                return RedirectToAction("GetAllCars");
            }
            else
            {
                return RedirectToAction("Errormsg");
            }
           
        }

        
        
        public IActionResult Delete(int Vin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _customerBusiness.Delete(Vin);
            return RedirectToAction("GetAllCars");
        }
    }

}
