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
    /// 域名分类服务
    /// </summary>
    public class DomainTypeService : CrudServiceBase<DomainType, DomainTypeDto, DomainTypeQuery>, IDomainTypeService {
        /// <summary>
        /// 初始化域名分类服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="domainTypeRepository">域名分类仓储</param>
        public DomainTypeService( IAgentsUnitOfWork unitOfWork, IDomainTypeRepository domainTypeRepository )
            : base( unitOfWork, domainTypeRepository ) {
            DomainTypeRepository = domainTypeRepository;
        }
        
        /// <summary>
        /// 域名分类仓储
        /// </summary>
        public IDomainTypeRepository DomainTypeRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<DomainType> CreateQuery( DomainTypeQuery param ) {
            return new Query<DomainType>( param );
        }
    }
}