using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbcontext dbcontext;

        public EmployeesController(ApplicationDbcontext dbcontext)
        {
            this.dbcontext = dbcontext;
        }


        [HttpGet]

        public IActionResult GetAllEmployees()
        {
           var allEmployees = dbcontext.Employees.ToList();

            return Ok(allEmployees);


        }

        [HttpPost]

        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new EmployeeAdminPortal()
            {
                 Name {}                                                                       
            }
            dbcontext.Employees.Add()
        }


    }
}
