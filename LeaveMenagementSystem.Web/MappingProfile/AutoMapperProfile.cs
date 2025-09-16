using EmitMapper;
using LeaveMenagementSystem.Web.Data;
using LeaveMenagementSystem.Web.Models.LeaveTypes;

namespace LeaveMenagementSystem.Web.MappingProfile
{
    public static class EmitMapperConfig
    {
        public static ObjectsMapper<LeaveType, LeaveTypeReadOnlyVM> LeaveTypeToIndexVmMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveType, LeaveTypeReadOnlyVM>();

        public static ObjectsMapper<LeaveTypeCreateVM, LeaveType> LeaveTypeToIndexVMMapper = ObjectMapperManager.DefaultInstance.GetMapper<LeaveTypeCreateVM, LeaveType>();
    }
}
