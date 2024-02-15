using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModels
{
    public class HomeDetailsViewModel
    {
        internal IEnumerable<Employee>? employee;

        public Employee? Employee { get; set; }
        public string? PageTitle { get; set; }
    }
}
    