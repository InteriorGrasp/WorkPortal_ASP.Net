using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class EmployeeLogin
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }

        //FK
        [Required]
        public int EmployeeId { get; set; }

        //Child Reference
        public Employee? Employee { get; set; }
    }
}
