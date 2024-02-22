using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {

        internal int id;

        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid Email Format")]
        public string? Email { get; set; }
        [Required]
        public EnumDep? Department { get; set; }
    }
}
