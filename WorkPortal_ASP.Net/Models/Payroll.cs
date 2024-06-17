using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Payroll
    {
        [Key]
        [Required]
        public int PayrollId { get; set; }

        [Required]
        public string PaymentDate { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Account {  get; set; }

        //FK
        [Required]
        public int EmployeeId { get; set; }

        //Parent reference
        public Employee? Employee { get; set; }


    }
}
