
namespace WebApp.Models
{
    public class MokeEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MokeEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { ID = 1, Name = "Moaiz", Department = "AI", Email = "moaizuk@gmail.com" },
                new Employee() { ID = 2, Name = "Sarmad", Department = "ML", Email = "sarmaduk@gmail.com" },
                new Employee() { ID = 3, Name = "Zain", Department = "S/W", Email = "zainuk@gmail.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.ID == id);
        }
    }
}
