using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveMenagementSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }
        public int NumberOfDays { get; set; }
    }
}
