using System.ComponentModel.DataAnnotations;

namespace WorkPortal_ASP.Net.Models
{
    public class Attendance
    {
        [Required]
        public int AttendanceId { get; set; }

        [Required]
        public string DateOfAttendace { get; set; }

        [Required]
        public int TimeIn {  get; set; }

        [Required]
        public int TimeOut { get; set; }

        public int ExtraHours { get; set; }

        [Required]
        public int TotalHours { get; set; }

        //Parent reference
        public Employee? EmployeeId { get; set; }

        

    }
}
