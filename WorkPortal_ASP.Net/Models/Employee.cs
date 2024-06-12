using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Employee
    {
        // PK
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        // FK
        public int DepartmentId { get; set; }

        //Parent reference
        //Because from 1 Department we have many employees
        [Required]  
        public Department? Department { get; set; }

        //Child reference
        //Because from One employee we have many attendance
        public List<Attendance>? Attendances {get;set;}

        //Child Reference
        //Because From One employee we have many payments'
        public List<Payroll>? Payrolls { get;set;}

    }
}
