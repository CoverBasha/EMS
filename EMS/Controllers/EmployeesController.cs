using Microsoft.AspNetCore.Mvc;
using EMS.Models;
namespace EMS.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new();
        }

        public IActionResult Create(Employee employee)
        {
            
            return View();
        }

        public IActionResult Return(Employee employee)
        {
            return View();
        }

        public IActionResult Update(Employee employee)
        {
            return View();
        }

        public IActionResult Delete(Employee employee)
        {
            return View();
        }
    }
}
