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
    /// 域名服务
    /// </summary>
    public class DomainService : CrudServiceBase<Domain, DomainDto, DomainQuery>, IDomainService {
        /// <summary>
        /// 初始化域名服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="domainRepository">域名仓储</param>
        public DomainService( IAgentsUnitOfWork unitOfWork, IDomainRepository domainRepository )
            : base( unitOfWork, domainRepository ) {
            DomainRepository = domainRepository;
        }
        
        /// <summary>
        /// 域名仓储
        /// </summary>
        public IDomainRepository DomainRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Domain> CreateQuery( DomainQuery param ) {
            return new Query<Domain>( param );
        }
    }
}