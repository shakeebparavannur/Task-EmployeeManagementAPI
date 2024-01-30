using AutoMapper;
using EmployeeManagement.Models;

namespace EmployeeManagement.Mapper
{
    public class EmployeeMapper:Profile
    {
        public EmployeeMapper()
        {
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            CreateMap<Work,WorkDto>().ReverseMap();
        }
    }
}
