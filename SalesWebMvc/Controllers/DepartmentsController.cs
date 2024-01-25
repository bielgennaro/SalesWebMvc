using Microsoft.AspNetCore.Mvc;

using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            var departmentsList = new List<Department>()
            {
                new Department
                {
                    Id = 1,
                    Name = "Eletrônicos",
                    DepartmentCode = 1823
                },

                new Department
                {
                    Id = 2,
                    Name = "Fashion",
                    DepartmentCode = 1845
                }
            };

            return View(departmentsList);
        }
    }
}
