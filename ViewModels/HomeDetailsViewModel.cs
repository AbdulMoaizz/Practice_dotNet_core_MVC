using WebApp.Models;

namespace EmployeeManagement.ViewModels
{
    public class HomeDetailsViewModel
    {
        internal Employee employeeDep;
        internal IEnumerable<Employee> employee;
        private string v;
        private object dep;

        public HomeDetailsViewModel()
        {
        }

        public HomeDetailsViewModel(string v, object dep)
        {
            this.v = v;
            this.dep = dep;
        }

        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
    }
}
    