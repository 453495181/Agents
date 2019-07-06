using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Queries.Distributions;
using Agents.Service.Abstractions.Distributions;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Distributions {
    /// <summary>
    /// 佣金控制器
    /// </summary>
    public class CommissionController : QueryControllerBase<CommissionDto, CommissionQuery> {
        /// <summary>
        /// 初始化佣金控制器
        /// </summary>
        /// <param name="service">佣金服务</param>
        public CommissionController( ICommissionService service ) : base( service ) {
            CommissionService = service;
        }
        
        /// <summary>
        /// 佣金服务
        /// </summary>
        public ICommissionService CommissionService { get; }

		
        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(CommissionQuery query) {
            PagerQueryBefore(query);
            var result = await CommissionService.PagerQueryCommissionAsync(query);
            return Success(ToPagerQueryResult(result));
        }
    }
}