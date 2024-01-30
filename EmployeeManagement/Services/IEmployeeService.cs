using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee>GetEmployeeById(int id);
        Task<Employee> AddEmployee(EmployeeDto employee);
    }
}
