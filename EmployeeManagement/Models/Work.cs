using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        public string WorkType { get; set; }
        public int EmployeeId { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public Employee employee { get; set; }
    }
}
