using System.Threading.Tasks;
using Util.Webs.Controllers;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;
using Microsoft.AspNetCore.Mvc;
using Util.Webs.Properties;

namespace Agents.Apis.Agents {
    /// <summary>
    /// 代理控制器
    /// </summary>
    public class AgentController : CrudControllerBase<AgentDto, AgentQuery> {
        /// <summary>
        /// 初始化代理控制器
        /// </summary>
        /// <param name="service">代理服务</param>
        public AgentController( IAgentService service ) : base( service ) {
            AgentService = service;
        }

        /// <summary>
        /// 代理服务
        /// </summary>
        public IAgentService AgentService { get; }

        /// <summary>
        /// 创建
        /// </summary>
        /// <remarks>
        /// 调用范例:
        /// POST
        /// /api/customer
        /// </remarks>
        /// <param name="request">创建参数</param>
        [HttpPost]
        public override async Task<IActionResult> CreateAsync([FromBody] AgentDto request) {
            if (request == null)
                return Fail(WebResource.CreateRequestIsEmpty);
            CreateBefore(request);
            var id = await AgentService.CreateAsync(request);
            var result = await AgentService.GetByIdAsync(id);
            return Success(result);
        }
    }
}