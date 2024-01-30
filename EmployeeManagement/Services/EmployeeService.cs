using AutoMapper;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _context;
        private readonly IMapper mapper;
        public EmployeeService(EmployeeDbContext context,IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }
       
        public async Task<Employee> AddEmployee(EmployeeDto employee)
        {
            var _employee = mapper.Map<Employee>(employee);
            if (_employee != null)
            {
              await _context.Employees.AddAsync(_employee);
              await _context.SaveChangesAsync();
              return _employee;
            }
            return null;
        }
     
        public async Task<Employee> GetEmployeeById(int id)
        {
           var employee = await _context.Employees.Include(w=>w.Works).FirstOrDefaultAsync(x=>x.EmpId == id);
            if (employee == null)
            {
                throw new ArgumentException("User Not Found");
            }
            return employee;

        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees =await _context.Employees.Include(x=>x.Works).ToListAsync();
            if(employees == null)
            {
                throw new ArgumentException("Not Found");
            }
            return employees;
        }
    }
}
