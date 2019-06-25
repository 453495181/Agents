using Util.Applications;
using Agents.Service.Dtos.Members;
using Agents.Service.Queries.Members;

namespace Agents.Service.Abstractions.Members {
    /// <summary>
    /// 会员服务
    /// </summary>
    public interface IMemberService : ICrudService<MemberDto, MemberQuery> {
    }
}