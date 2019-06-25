using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Queries.Distributions;
using Agents.Service.Abstractions.Distributions;

namespace Agents.Service.Implements.Distributions {
    /// <summary>
    /// 佣金服务
    /// </summary>
    public class CommissionService : CrudServiceBase<Commission, CommissionDto, CommissionQuery>, ICommissionService {
        /// <summary>
        /// 初始化佣金服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="commissionRepository">佣金仓储</param>
        public CommissionService( IAgentsUnitOfWork unitOfWork, ICommissionRepository commissionRepository )
            : base( unitOfWork, commissionRepository ) {
            CommissionRepository = commissionRepository;
        }
        
        /// <summary>
        /// 佣金仓储
        /// </summary>
        public ICommissionRepository CommissionRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Commission> CreateQuery( CommissionQuery param ) {
            return new Query<Commission>( param );
        }
    }
}