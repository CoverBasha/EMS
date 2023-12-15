using Microsoft.AspNetCore.Mvc;
using EMS.Models;
namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Employees);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
		public IActionResult PostAdd(Employee emp)
		{
            ViewBag.ModelState = ModelState.IsValid;

            if (ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();

                emp.Id = 1;
            }
			return View("Add", emp);
		}

		public IActionResult Edit(int id)
		{
			return View(_context.Employees.FirstOrDefault(x => x.Id == id));
		}

        [HttpPost]
		public IActionResult Update(Employee emp)
        {
            ViewBag.ModelState = ModelState.IsValid;

            if (ModelState.IsValid)
            {
                var employee = _context.Employees.FirstOrDefault(x => x.Id == emp.Id);
                if (employee != null)
                {
                    employee.Name = emp.Name;
                    employee.Email = emp.Email;
                    employee.Phone = emp.Phone;
                    employee.Department = emp.Department;

                    _context.SaveChanges();
                }
                else
                    return View("Edit", null);
            }

            return View("Edit", emp);
        }

		public IActionResult Delete(int id)
		{
            return View(_context.Employees.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();

                return RedirectToAction("Index", "Employee");
            }

            return View("Delete", null);
        }
	}
}
