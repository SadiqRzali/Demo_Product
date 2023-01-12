using BusinesLayer.Concrete;
using BusinesLayer.Validation;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager c = new ProductManager(new EFProductDal());
        public IActionResult Index()
        {

            var values = c.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidatior cr = new ProductValidatior();
            ValidationResult results =  cr.Validate(p);
            if(results.IsValid)
            {
                c.TInsert(p);
                return RedirectToAction("Index");
            }

            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
         

        }



        public IActionResult DeleteProduct(int id)
        {
            var value = c.GetById(id);
            c.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {

            var value = c.GetById(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
           
            c.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
