
namespace CommunitySafety.Application.DTOs;

public class IncidentDTO
{
    public int? Id { get; set; }
    public string? Description { get; set; }
    public int? CategoryId { get; set; }
    public int? LocationId { get; set; }
    public LocationDTO? Location { get; set; }
    public CategoryDTO? Category { get; set; }
}
