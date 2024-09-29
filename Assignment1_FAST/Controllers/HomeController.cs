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

    [HttpGet]
    public IActionResult AllEquipment()
    {
        var allEquipment = new AllEquipment();
        return View(allEquipment);
    }

    [HttpGet]
    public IActionResult AvailableEquipment()
    {
        var allEquipment = new AllEquipment();
        var availableEquipment = allEquipment.EquipmentList.Where(r => r.IsAvailable);

        return View(availableEquipment);
    }


}


