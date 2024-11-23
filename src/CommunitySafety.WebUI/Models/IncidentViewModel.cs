using CommunitySafety.Application.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CommunitySafety.WebUI.Models;

public class IncidentViewModel
{
    public IncidentDTO Incident { get; set; }
    public LocationDTO Location { get; set; }
    public SelectList Categories { get; set; }
}
