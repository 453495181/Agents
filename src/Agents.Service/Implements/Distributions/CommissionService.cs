using System;
using System.Linq;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Data.Conditions.Distributions;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Services.Abstractions;
using Agents.Distributions.Domain.Repositories;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Dtos.Distributions.Extensions;
using Agents.Service.Queries.Distributions;
using Agents.Service.Abstractions.Distributions;
using Microsoft.EntityFrameworkCore;

namespace Agents.Service.Implements.Distributions {
    /// <summary>
    /// 佣金服务
    /// </summary>
    public class CommissionService : DeleteServiceBase<Commission, CommissionDto, CommissionQuery>, ICommissionService {
        /// <summary>
        /// 初始化佣金服务
        /// </summary>
        public CommissionService(IAgentsUnitOfWork unitOfWork, ICommissionRepository commissionRepository, ICommissionManager commissionManager, IAgentManager agentManager)
            : base(unitOfWork, commissionRepository) {
            UnitOfWork = unitOfWork;
            CommissionRepository = commissionRepository;
            CommissionManager = commissionManager;
            AgentManager = agentManager;
        }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 佣金仓储
        /// </summary>
        public ICommissionRepository CommissionRepository { get; set; }

        /// <summary>
        /// 佣金管理器
        /// </summary>
        public ICommissionManager CommissionManager { get; set; }

        /// <summary>
        /// 代理管理器
        /// </summary>
        public IAgentManager AgentManager { get; }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public async Task<PagerList<CommissionDto>> PagerQueryCommissionAsync(CommissionQuery parameter) {
            if (parameter == null)
                return new PagerList<CommissionDto>();
            var query = await CreateQuery(parameter);
            var queryable = CommissionRepository.FindAsNoTracking().Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected new async Task<IQueryBase<Commission>> CreateQuery(CommissionQuery param) {
            var currentAgent = await AgentManager.GetCurrentAgentAsync();
            var queryCondition = new CommissionQueryCondition(currentAgent);
            return new Query<Commission>(param)
                .Where(queryCondition);
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<Commission> Filter(IQueryable<Commission> queryable, CommissionQuery parameter) {
            return queryable.Include(t => t.Order).Include(t=>t.Agent);
        }

        /// <summary>
        /// 转换为数据传输对象
        /// </summary>
        protected override CommissionDto ToDto(Commission entity) {
            return entity.ToDto();
        }
    }
}