using Agents.Service.Abstractions.Agents;
using Agents.Service.Abstractions.Finances;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Util;
using Util.Webs.Controllers;
using Util.Webs.Properties;

namespace Agents.Apis.Agents
{
    /// <summary>
    /// 提现控制器
    /// </summary>
    public class OutCashController : QueryControllerBase<OutCashDto, OutCashQuery>
    {
        /// <summary>
        /// 初始化提现控制器
        /// </summary>
        /// <param name="service">提现服务</param>
        public OutCashController(IOutCashService service, IAccountService accountService) : base(service)
        {
            OutCashService = service;
            AccountService = accountService;
        }

        /// <summary>
        /// 提现服务
        /// </summary>
        public IOutCashService OutCashService { get; }

        /// <summary>
        /// 账户服务
        /// </summary>
        public IAccountService AccountService { get; }

        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(OutCashQuery query)
        {
            PagerQueryBefore(query);
            var result = await OutCashService.PagerQueryOutCashAsync(query);
            return Success(ToPagerQueryResult(result));
        }



        /// <summary>
        /// 根据Id获取提现
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id)
        {
            var byIdAsync = await OutCashService.GetOutCashByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }

        /// <summary>
        /// 获取账户可提现余额
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("GetAbleMoney")]
        public async Task<IActionResult> GetAbleMoney(Guid id)
        {
            var account = await AccountService.GetByIdAsync(id);
            return Success(account.Balance);
        }

        /// <summary>
        /// 创建提现
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OutCashCreateRequest request)
        {
            if (request == null)
            {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await OutCashService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>
        /// 修改提现
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] OutCashUpdateRequest request)
        {
            if (request == null)
            {
                return Fail(WebResource.UpdateRequestIsEmpty);
            }

            if (id.IsEmpty() && request.OutCashId.IsEmpty())
            {
                return Fail(WebResource.IdIsEmpty);
            }

            if (request.OutCashId.IsEmpty())
            {
                request.OutCashId = id.ToGuid();
            }

            await OutCashService.UpdateAsync(request);
            OutCashDto byIdAsync = await OutCashService.GetByIdAsync(request.OutCashId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 审核提现
        /// </summary>
        [HttpPost("audit")]
        public async Task<IActionResult> AuditAsync(string id)
        {
            await OutCashService.AuditOutCash(id);
            return Success("ok");
        }


        /// <summary>
        /// 拒绝提现
        /// </summary>
        [HttpPost("refuse")]
        public async Task<IActionResult> RefuseAsync(string id)
        {
            await OutCashService.RefuseOutCash(id);
            return Success("ok");
        }

        

        /// <summary>
        /// 取消提现
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            await OutCashService.DeleteOutCash(id);
            return Success();
        }

        /// <summary>
        /// 批量取消提现
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids)
        {
            await OutCashService.DeleteOutCash(ids);
            return Success();
        }
    }
}