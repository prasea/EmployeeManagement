using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController()
        {
            _employeeRepository = new MockEmployeeRepository();
        }
        public ViewResult Index()
        {
            var employeeModel = _employeeRepository.GetAllEmployees();
            return View(employeeModel);
        }
        public ViewResult Details()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            return View(homeDetailsViewModel);
        }

    }
}
