namespace WebApp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeebyDep(string dep);
        IEnumerable<Employee> GetEmployeebyDep();
    }
}
