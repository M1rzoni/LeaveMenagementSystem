using System.ComponentModel.DataAnnotations;

namespace LeaveMenagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    { 
        
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Maximum Alloaciton of Days")]
        public int NumberOfDays { get; set; }
    }
}