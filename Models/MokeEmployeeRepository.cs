﻿namespace EmployeeManagement.Models
{
    public class MokeEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MokeEmployeeRepository()
        {
            _employeeList =
            [
                new() { Id = 1, Name = "Moaiz", Department = EnumDep.IT, Email = "moaizuk@gmail.com" },
                new() { Id = 2, Name = "Sarmad", Department = EnumDep.Payroll, Email = "sarmaduk@gmail.com" },
                new() { Id = 3, Name = "Zain", Department = EnumDep.HR, Email = "zainuk@gmail.com" },
                new() { Id = 4, Name = "Faisal", Department = EnumDep.IT, Email = "faisaluk@gmail.com" },
                new() { Id = 5, Name = "Abbas", Department = EnumDep.Payroll, Email = "abbasuk@gmail.com" },
                new() { Id = 6, Name = "Hassan", Department = EnumDep.None, Email = "hassanuk@gmail.com" },
                new() { Id = 7, Name = "Ahmad", Department = EnumDep.IT, Email = "ahmaduk@gmail.com" },
                new() { Id = 8, Name = "Aftab", Department = EnumDep.Payroll, Email = "aftabuk@gmail.com" },
                new() { Id = 9, Name = "Sheri", Department = EnumDep.HR, Email = "sheriuk@gmail.com" }
            ];
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public IEnumerable<Employee> GetDepEmployee(string dep)
        {
            return _employeeList.Where(e => e.Department == EnumDep.IT);
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
