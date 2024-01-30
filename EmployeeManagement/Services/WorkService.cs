using AutoMapper;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Services
{
    public class WorkService : IWorkService
    {
        private readonly EmployeeDbContext _context;
        private readonly IMapper mapper;
        public WorkService(EmployeeDbContext dbContext,IMapper mapper)
        {
            _context = dbContext;
            this.mapper = mapper;
        }
        public async Task<Work> AddNewWork(WorkDto work)
        {
            var _work = mapper.Map<Work>(work);
            await _context.AddAsync(_work);
            await _context.SaveChangesAsync();
            return _work;
        }

        public async Task<IEnumerable<Work>> GetAllWorks()
        {
            var works = await _context.Works.ToListAsync();
            return works;
        }

        public async Task<IEnumerable<Work>> GetAllWorksWithEmplId(int empId)
        {
            var works = await _context.Works.Where(x=>x.EmployeeId == empId).ToListAsync();
            return works;
        }
    }
}
