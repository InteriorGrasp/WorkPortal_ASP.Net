using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Employee
    {   
        //PK
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // FK
        [Required]
        public int DepartmentId { get; set; }
    }
}
