using Microsoft.AspNetCore.Mvc;
using modelsdemo.Models;

namespace modelsdemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return View();
           
        }
       
       
    }
}
