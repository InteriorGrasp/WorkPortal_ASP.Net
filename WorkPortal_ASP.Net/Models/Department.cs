using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Department
    {   
        //PK
        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        //Child Reference
        //Because from 1 department we can have many employees 
        public List<Employee>? Employees { get; set;}

    }
}
