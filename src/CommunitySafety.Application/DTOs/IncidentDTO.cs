
using System.ComponentModel.DataAnnotations;

namespace CommunitySafety.Application.DTOs;

public class IncidentDTO
{
    public int Id { get; set; }

    [Required(ErrorMessage = "The Description is Required")]
    [MinLength(3)]
    [MaxLength(50)]
    public string Description { get; set; }
}
