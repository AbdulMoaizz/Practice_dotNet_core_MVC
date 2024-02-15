namespace EmployeeManagement.Models
{
    public class MokeEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MokeEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Moaiz", Department = "AI", Email = "moaizuk@gmail.com" },
                new Employee() { Id = 2, Name = "Sarmad", Department = "ML", Email = "sarmaduk@gmail.com" },
                new Employee() { Id = 3, Name = "Zain", Department = "S/W", Email = "zainuk@gmail.com" },
                new Employee() { Id = 4, Name = "Faisal", Department = "AI", Email = "faisaluk@gmail.com" },
                new Employee() { Id = 5, Name = "Abbas", Department = "ML", Email = "abbasuk@gmail.com" },
                new Employee() { Id = 6, Name = "Hassan", Department = "S/W", Email = "hassanuk@gmail.com" },
                new Employee() { Id = 7, Name = "Ahmad", Department = "AI", Email = "ahmaduk@gmail.com" },
                new Employee() { Id = 8, Name = "Aftab", Department = "ML", Email = "aftabuk@gmail.com" },
                new Employee() { Id = 9, Name = "Sheri", Department = "S/W", Email = "sheriuk@gmail.com" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public IEnumerable<Employee> GetDepEmployee(string dep)
        {
            return _employeeList.Where(e => e.Department == "ML");
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
