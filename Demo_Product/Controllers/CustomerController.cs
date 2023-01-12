using BusinesLayer.Concrete;
using BusinesLayer.Validation;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Demo_Product.Controllers
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        CustomerManager cm = new CustomerManager(new EFCustomerDal());
        public IActionResult Index()
        {
            var value = cm.GetListCustomers();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {

            JobManager jm = new JobManager(new EFJobDal());
            List<SelectListItem> values = (from x in jm.TGetList()
                                           select new SelectListItem
                                           {

                                               Text = x.JobName,
                                               Value = x.JobID.ToString()

                                           }).ToList();

            ViewBag.v1 = values;


            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {

          
                cm.TInsert(p);
                return RedirectToAction("Index");
            

       
        }


        public IActionResult DeleteCustomer(int id)
        {
            var value = cm.GetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            JobManager jm = new JobManager(new EFJobDal());
            List<SelectListItem> values = (from x in jm.TGetList()
                                           select new SelectListItem
                                           {

                                               Text = x.JobName,
                                               Value = x.JobID.ToString()

                                           }).ToList();

            ViewBag.v1 = values;
            var value = cm.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            cm.TUpdate(p);
            return RedirectToAction("Index");
        }







    }
}
