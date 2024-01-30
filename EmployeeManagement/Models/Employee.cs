using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Contact {  get; set; }
        public string ImageUrl {  get; set; }

        public virtual ICollection<Work> Works { get; set; }

    }
}
