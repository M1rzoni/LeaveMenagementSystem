using EmitMapper;
using LeaveMenagementSystem.Web.Data;
using LeaveMenagementSystem.Web.Models.LeaveTypes;

namespace LeaveMenagementSystem.Web.MappingProfile
{
    public static class EmitMapperConfig
    {
        public static ObjectsMapper<LeaveType, LeaveTypeReadOnlyVM> LeaveTypeToIndexVmMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveType, LeaveTypeReadOnlyVM>();

        public static ObjectsMapper<LeaveTypeCreateVM, LeaveType> LeaveTypeCreateToEntityMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveTypeCreateVM, LeaveType>();

        public static ObjectsMapper<LeaveType, LeaveTypeEditVM> LeaveTypeToEditVMMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveType, LeaveTypeEditVM>();

        public static ObjectsMapper<LeaveTypeEditVM, LeaveType> EditVMToLeaveTypeMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveTypeEditVM, LeaveType>();
    }
}
