using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class StaffLogin

    {
        //Primary Key

        [Required]
        public required string UsernameId;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long and not exceed 100 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string Password;

        //FK
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }

        //Child reference
        public Employee? Employee { get; set; }
    }
}
