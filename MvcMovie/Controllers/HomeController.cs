using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput ="xin chào" + FullName + "đến từ" + Address;
        Viewbag.Message = strOutput;
        return View();
    }
   
}
