using Microsoft.AspNetCore.Mvc;

namespace CommunitySafety.WebUI.Controllers;

public class ViewIncidentController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
