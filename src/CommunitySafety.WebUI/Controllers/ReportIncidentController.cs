using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;
using CommunitySafety.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunitySafety.WebUI.Controllers;

public class ReportIncidentController : Controller
{
    private readonly ICategoryService _categoryServices;
    private readonly IIncidentService _incidentService;
    private readonly ILocationService _locationService;

    public ReportIncidentController(ICategoryService categoryService, IIncidentService incidentService, ILocationService locationService)
    {
        _categoryServices = categoryService;
        _incidentService = incidentService;
        _locationService = locationService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var categoryDto = await _categoryServices.GetCategoriesAsync();

        var incidentViewModel = new IncidentViewModel()
        {
            Incident = new IncidentDTO(),
            Location = new LocationDTO(),
            Categories = new SelectList(categoryDto, "Id", "Name")
        };
        return View(incidentViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Create(IncidentViewModel viewModel)
    {
        var locationDTO = await _locationService.GetLocationByLatitudeAndLongitude(viewModel.Location);

        if(locationDTO is null)
            locationDTO = await _locationService.AddAsync(viewModel.Location);

        var incidentDTO = new IncidentDTO()
        {
            LocationId = locationDTO.Id,
            CategoryId = viewModel.Incident.CategoryId,
            Description = viewModel.Incident.Description
        };

        var result = await _incidentService.AddAsync(incidentDTO);

        return Json(new { success = true });
    }
}
