using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using WebApp.Models;
using WebApplication1.Models;

namespace EmployeeMangement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {

            var model = _employeeRepository.GetAllEmployees();
            return View(model);

        }

        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.PageTitle = "Employee Data";
            return View(model);

        }
    }
}
