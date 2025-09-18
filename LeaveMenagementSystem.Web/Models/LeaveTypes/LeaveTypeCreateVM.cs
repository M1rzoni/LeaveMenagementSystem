using System.ComponentModel.DataAnnotations;

namespace LeaveMenagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(4,150, ErrorMessage ="You have violated the length requrements")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 90)]
        [Display(Name="Maximum Alloaciton of Days")]
        public int NumberOfDays { get; set; }   
        
    }
           
}