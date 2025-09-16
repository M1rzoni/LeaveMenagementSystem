using EmitMapper;
using LeaveMenagementSystem.Web.Data;
using LeaveMenagementSystem.Web.Models.LeaveTypes;

namespace LeaveMenagementSystem.Web.MappingProfile
{
    public static class EmitMapperConfig
    {
        public static ObjectsMapper<LeaveType, IndexVM> LeaveTypeToIndexVmMapper =
            ObjectMapperManager.DefaultInstance.GetMapper<LeaveType, IndexVM>();
    }
}
