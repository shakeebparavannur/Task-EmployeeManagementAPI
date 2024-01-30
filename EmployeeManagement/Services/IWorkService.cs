using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IWorkService
    {
        Task<Work> AddNewWork (WorkDto work);
        Task<IEnumerable<Work>> GetAllWorks ();
        Task<IEnumerable<Work>> GetAllWorksWithEmplId (int empId);
    }
}
