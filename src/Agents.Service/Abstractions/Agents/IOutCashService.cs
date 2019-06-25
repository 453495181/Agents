using Util.Applications;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;

namespace Agents.Service.Abstractions.Agents {
    /// <summary>
    /// 提现服务
    /// </summary>
    public interface IOutCashService : ICrudService<OutCashDto, OutCashQuery> {
    }
}