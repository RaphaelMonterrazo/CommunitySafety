using CommunitySafety.Application.Interfaces;
using CommunitySafety.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunitySafety.WebUI.Controllers;

public class ViewIncidentController : Controller
{
    private readonly IIncidentService _incidentService;
    public ViewIncidentController(IIncidentService incidentService)
    {
        _incidentService = incidentService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var incidents = await _incidentService.GetAllAsync();

        var viewModel = new ViewIncidentViewModel()
        {
            Incidents = incidents.ToList()
        };

        return View(viewModel);
    }
}
