using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment1_FAST.Models;

namespace Assignment1_FAST.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();

    }
}


