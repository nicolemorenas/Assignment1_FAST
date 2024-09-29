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

    [HttpGet]
    public ViewResult RequestForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RequestForm(RequestResponse requestResponse)
    {
        if (ModelState.IsValid)
        {
        Repository.AddRequest(requestResponse);
        return View("Confirmation", requestResponse);
        } else
        {
            return View();
        }
       
    }

}


