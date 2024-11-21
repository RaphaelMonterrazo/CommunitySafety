using CommunitySafety.Application.Interfaces;
using CommunitySafety.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunitySafety.WebUI.Controllers;

public class ReportIncidentController : Controller
{
    private readonly ICategoryService _categoryServices;

    public ReportIncidentController(ICategoryService categoryService)
    {
        _categoryServices = categoryService;              
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var categoryDto = await _categoryServices.GetCategoriesAsync();

        var incidentViewModel = new IncidentViewModel()
        {
            Categories = new SelectList(categoryDto, "Id", "Name")
        };
        return View(incidentViewModel);
    }
}
