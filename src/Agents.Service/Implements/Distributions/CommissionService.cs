using System;
using System.Linq;
using System.Threading.Tasks;
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

namespace Agents.Service.Implements.Distributions {
    /// <summary>
    /// 佣金服务
    /// </summary>
    public class CommissionService : DeleteServiceBase<Commission, CommissionDto, CommissionQuery>, ICommissionService {
        /// <summary>
        /// 初始化佣金服务
        /// </summary>
        public CommissionService( IAgentsUnitOfWork unitOfWork, ICommissionRepository commissionRepository, ICommissionManager commissionManager)
            : base( unitOfWork, commissionRepository ) {
			UnitOfWork = unitOfWork;
            CommissionRepository = commissionRepository;
			CommissionManager = commissionManager;

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
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public async Task<PagerList<CommissionDto>> PagerQueryCommissionAsync(CommissionQuery parameter) {
            if (parameter == null)
                return new PagerList<CommissionDto>();
            var query = await CreateQuery(parameter);
            var queryable =  CommissionRepository.FindAsNoTracking().Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected new async Task<IQueryBase<Commission>> CreateQuery(CommissionQuery param) {
            var queryCondition = new CommissionQueryCondition();
            return new Query<Commission>(param)
                .Where(queryCondition);
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<Commission> Filter(IQueryable<Commission> queryable, CommissionQuery parameter) {
            return queryable;
        }

        /// <summary>
        /// 异步获取佣金
        /// </summary>
        public async Task<CommissionDto> GetCommissionByIdAsync(Guid id) {
            var entity = await CommissionRepository.FindAsync(id);
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加佣金
        /// </summary>
        public async Task<Guid> CreateAsync(CommissionCreateRequest request) {
            var commission = request.MapTo<Commission>();
            commission = await CommissionManager.CreateCommissionAsync(commission);
            await UnitOfWork.CommitAsync();
            return commission.Id;
        }

        /// <summary>
        /// 修改佣金
        /// </summary>
        public async Task UpdateAsync(CommissionUpdateRequest request) {
            var entity = await CommissionRepository.FindAsync(request.CommissionId);
            request.MapTo(entity);
            await CommissionRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除佣金
        /// </summary>
        public async Task DeleteCommission(string ids) {
            await CommissionManager.DeleteCommission(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}