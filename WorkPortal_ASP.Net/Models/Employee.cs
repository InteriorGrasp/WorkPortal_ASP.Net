using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Employee
    {
        // PK
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)] // Ejemplo de longitud máxima
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; } // Corregido el error tipográfico

        [Phone]
        public string PhoneNumber { get; set; } // Cambiado a string

        [EmailAddress]
        public string Email { get; set; }

        // FK
        [Required]
        public int DepartmentId { get; set; }
    }
}
