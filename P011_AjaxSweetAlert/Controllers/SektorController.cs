using Microsoft.AspNetCore.Mvc;
using P011_AjaxSweetAlert.Context;
using P011_AjaxSweetAlert.Models;

namespace P011_AjaxSweetAlert.Controllers
{
    public class SektorController : Controller
    {
        private readonly DataContext _context;

        public SektorController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Sektor sektor)
        {
            if(!ModelState.IsValid)
                return RedirectToAction("Index");

            _context.Add(sektor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
