using Agents.Service.Abstractions.Agents;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Webs.Controllers;
using Util.Webs.Properties;

namespace Agents.Apis.Agents
{
    /// <summary>
    /// 代理控制器
    /// </summary>
    public class SubAgentController : QueryControllerBase<AgentDto, SubAgentQuery>
    {
        /// <summary>
        /// 初始化代理控制器
        /// </summary>
        /// <param name="service">代理服务</param>
        public SubAgentController(ISubAgentService service, IAgentManager agentManager) : base(service)
        {
            AgentService = service;
            AgentManager = agentManager;
        }

        /// <summary>
        /// 代理服务
        /// </summary>
        public ISubAgentService AgentService { get; }

        /// <summary>
        /// 代理管理器
        /// </summary>
        public IAgentManager AgentManager { get; }

        

        /// <summary>获取单个实例</summary>
        /// <remarks>
        /// 调用范例:
        /// GET
        /// /api/customer/1
        /// </remarks>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id)
        {
            var byIdAsync = await AgentService.GetAgentByIdAsync(id.ToGuid());
            return Success(byIdAsync, null);
        }

        /// <summary>
        /// 我的代理信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("mine")]
        public async Task<IActionResult> MineAsync()
        {
            var byIdAsync = await AgentManager.GetCurrentAgentAsync();
            return Success(byIdAsync);
        }


        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="request">用户</param>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] AgentCreateRequest request)
        {
            if (request == null)
            {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await AgentService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>修改</summary>
        /// <remarks>
        /// 调用范例:
        /// PUT
        /// /api/customer/1
        /// </remarks>
        /// <param name="id">标识</param>
        /// <param name="request">修改参数</param>
        [HttpPut("{id?}")]
        public virtual async Task<IActionResult> UpdateAsync([FromBody] AgentUpdateRequest request)
        {
            if (request == null)
            {
                return Fail(WebResource.UpdateRequestIsEmpty);
            }
            
          
            await AgentService.UpdateAgentAsync(request);
            AgentDto byIdAsync = await AgentService.GetByIdAsync(request.Id);
            return Success(byIdAsync, null);
        }

        /// <summary>删除，注意：该方法用于删除单个实体，批量删除请使用POST提交，否则可能失败</summary>
        /// <remarks>
        /// 调用范例:
        /// DELETE
        /// /api/customer/1
        /// </remarks>
        /// <param name="id">标识</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            await AgentService.DeleteAgents(id);
            return Success();
        }

        /// <summary>批量删除，注意：body参数需要添加引号，"'1,2,3'"而不是"1,2,3"</summary>
        /// <remarks>
        /// 调用范例:
        /// POST
        /// /api/customer/delete
        /// body: "'1,2,3'"
        /// </remarks>
        /// <param name="ids">标识列表，多个Id用逗号分隔，范例：1,2,3</param>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids)
        {
            await AgentService.DeleteAgents(ids);
            return Success();
        }

    }
}