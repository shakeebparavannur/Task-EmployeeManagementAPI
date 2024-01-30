using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService service)
        {
            employeeService = service;
        }

        [HttpGet("getEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var response = await employeeService.GetEmployees();
                if (response != null)
                {
                    return Ok(response);
                }
                return NotFound("Sorry No User Found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            try
            {
                var response = await employeeService.GetEmployeeById(id);
                if (response != null)
                {
                    return Ok(response);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
        [HttpPost("add-employee")]

        public async Task<IActionResult> AddNewEmployee(EmployeeDto employee)
        {
            try
            {
                var response = await employeeService.AddEmployee(employee);
                if (response != null)
                {
                    return Ok(response);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }

        }

    }
}
