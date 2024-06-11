using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkPortal_ASP.Net.Models
{
    public class AdminLogin
    {
        //Primary KeY
        [Required(ErrorMessage = "Admin ID is required.")]
        [StringLength(50, ErrorMessage = "Admin ID cannot be longer than 50 characters.")]
        [Display(Name = "Admin ID")]
        public string AdminId { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long and not exceed 100 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        [Display(Name = "Department")]
        //Child reference
        public Department? Department { get; set; }

        //Foreign Key
        [Required(ErrorMessage = "Department ID is required.")]
        [ForeignKey("Department")]
        [Display(Name = "Department ID")]
        public int DepartmentId { get; set; }

    }
}
