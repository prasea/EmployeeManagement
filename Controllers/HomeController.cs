using EmployeeManagement.Models;
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
        //public JsonResult Index()
        //{
        //    return Json(new { id = 1, name = "Pragim" });
        //}
        public string Index()
        {
            string employeeName = _employeeRepository.GetEmployee(1).Name;
            return employeeName;
        }
        public JsonResult Details()
        {
            Employee employee = _employeeRepository.GetEmployee(1);
            return Json(employee);
        }
        public ObjectResult Details2()
        {
            Employee employee = _employeeRepository.GetEmployee(1);
            return new ObjectResult(employee);
        }
        public ViewResult Details3()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            return View(model);
        }
    }
}
