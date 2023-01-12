using BusinesLayer.Concrete;
using DataAcssesLayer.EntityFramvork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jm = new JobManager(new EFJobDal());
        public IActionResult Index()
        {
            var value = jm.TGetList();
            return View(value);
        }

        [HttpGet]
        public IActionResult AddJob()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            jm.TInsert(p);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteJob(int id)
        {
            var value = jm.GetById(id);
            jm.TDelete(value);
            return View();
        }



        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var value = jm.GetById(id);
            return View(value);
             
        }


        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {
            jm.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
