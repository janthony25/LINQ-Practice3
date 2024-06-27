using System.ComponentModel.DataAnnotations;

namespace LINQ_Practice3.Models
{
    public class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }

    }
}
