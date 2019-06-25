using Util.Webs.Controllers;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;

namespace Agents.Apis.Agents {
    /// <summary>
    /// 提现控制器
    /// </summary>
    public class OutCashController : CrudControllerBase<OutCashDto, OutCashQuery> {
        /// <param name="service">提现服务</param>
        public OutCashController( IOutCashService service ) : base( service ) {
            OutCashService = service;
        }

        /// <summary>
        /// 初始化提现控制器
        /// </summary>
        /// <summary>
        /// 提现服务
        /// </summary>
        public IOutCashService OutCashService { get; }
    }
}