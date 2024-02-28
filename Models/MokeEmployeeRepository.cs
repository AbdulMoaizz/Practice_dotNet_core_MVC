namespace EmployeeManagement.Models
{
    public class MokeEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MokeEmployeeRepository()
        {
            _employeeList =
            [
                new() { Id = 1, Name = "Moaiz", Department = Department.IT, Email = "moaizuk@gmail.com" },
                new() { Id = 2, Name = "Sarmad", Department = Department.Payroll, Email = "sarmaduk@gmail.com" },
                new() { Id = 3, Name = "Zain", Department = Department.HR, Email = "zainuk@gmail.com" },
                new() { Id = 4, Name = "Faisal", Department = Department.IT, Email = "faisaluk@gmail.com" },
                new() { Id = 5, Name = "Abbas", Department = Department.Payroll, Email = "abbasuk@gmail.com" },
                new() { Id = 6, Name = "Hassan", Department = Department.None, Email = "hassanuk@gmail.com" },
                new() { Id = 7, Name = "Ahmad", Department = Department.IT, Email = "ahmaduk@gmail.com" },
                new() { Id = 8, Name = "Aftab", Department = Department.Payroll, Email = "aftabuk@gmail.com" },
                new() { Id = 9, Name = "Sheri", Department = Department.HR, Email = "sheriuk@gmail.com" }
            ];
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {                
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public IEnumerable<Employee> GetDepEmployee(string dep)
        {
            return _employeeList.Where(e => e.Department == Department.IT);
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.id);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
