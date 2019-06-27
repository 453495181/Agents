using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;
using Util;
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
        public AgentController(IAgentService service) : base(service) {
            AgentService = service;
        }

        /// <summary>
        /// 代理服务
        /// </summary>
        public IAgentService AgentService { get; }


        /// <summary>
        /// 根据Id获取代理
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await AgentService.GetAgentByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }

        /// <summary>
        /// 创建代理
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AgentCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await AgentService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>
        /// 修改代理
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] AgentUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.AgentId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.AgentId.IsEmpty())
                request.AgentId = id.ToGuid();
            await AgentService.UpdateAsync(request);
            AgentDto byIdAsync = await AgentService.GetByIdAsync(request.AgentId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除代理
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await AgentService.DeleteAgents(id);
            return Success();
        }

        /// <summary>
        /// 批量删除代理
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await AgentService.DeleteAgents(ids);
            return Success();
        }
    }
}