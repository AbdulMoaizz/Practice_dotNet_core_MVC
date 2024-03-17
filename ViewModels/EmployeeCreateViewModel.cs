using System.ComponentModel.DataAnnotations;
using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModels;

public class EmployeeCreateViewModel
{
    [Required, MaxLength(20)]
    public string? Name { get; set; }
    [Required]
    [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
    public string? Email { get; set; }
    [Required]
    public Department? Department { get; set; }

    public IFormFile Photo { get; set; } 
}