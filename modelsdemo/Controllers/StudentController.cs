using Microsoft.AspNetCore.Mvc;
using modelsdemo.Models;

namespace modelsdemo.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return View();
        }
    }
}
