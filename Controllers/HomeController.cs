using Microsoft.AspNetCore.Mvc;

namespace WebApp_Uhrzeit.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        DateTime dt = DateTime.Now.AddDays(2);
        
        return View(dt);
    }
}