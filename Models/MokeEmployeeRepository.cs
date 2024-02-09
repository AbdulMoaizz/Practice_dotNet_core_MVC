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
                new Employee() { ID = 3, Name = "Zain", Department = "S/W", Email = "zainuk@gmail.com" },
                new Employee() { ID = 1, Name = "Faisal", Department = "AI", Email = "faisaluk@gmail.com" },
                new Employee() { ID = 2, Name = "Abbas", Department = "ML", Email = "abbasuk@gmail.com" },
                new Employee() { ID = 3, Name = "Hassan", Department = "S/W", Email = "hassanuk@gmail.com" },
                new Employee() { ID = 1, Name = "Ahmad", Department = "AI", Email = "ahmaduk@gmail.com" },
                new Employee() { ID = 2, Name = "Aftab", Department = "ML", Email = "aftabuk@gmail.com" },
                new Employee() { ID = 3, Name = "Sheri", Department = "S/W", Email = "sheriuk@gmail.com" }
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
            return _employeeList.FirstOrDefault(e => e.ID == id);
        }
    }
}
