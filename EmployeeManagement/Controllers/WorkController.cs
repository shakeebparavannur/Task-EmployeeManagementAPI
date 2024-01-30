using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IWorkService workService;
        public WorkController(IWorkService workService)
        {
            this.workService = workService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWorks()
        {
            try
            {
                var response = await workService.GetAllWorks();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorksWithEmpId(int empId)
        {
            try
            {
                var response = await workService.GetAllWorksWithEmplId(empId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddNewWork(WorkDto work)
        {
            try
            {
                var response = await workService.AddNewWork(work);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


            
    }
}
