using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string str0uput = "xin chao" + ps.PersonId + "-" + ps.Address;
            ViewBag.infoPerson = str0uput;
            return View();
        }
    }
}