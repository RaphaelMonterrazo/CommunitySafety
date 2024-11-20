using Microsoft.AspNetCore.Mvc;

namespace CommunitySafety.WebUI.Controllers
{
    public class ReportIncidentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
