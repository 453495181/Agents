using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Queries.Distributions;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 域名分类服务
    /// </summary>
    public interface IDomainTypeService : IDeleteService<DomainTypeDto, DomainTypeQuery> {
	
        /// <summary>
        /// 分页查询
        /// </summary>
        Task<PagerList<DomainTypeDto>> PagerQueryDomainTypeAsync(DomainTypeQuery parameter);

        /// <summary>
        /// 异步获取域名分类
        /// </summary>
        Task<DomainTypeDto> GetDomainTypeByIdAsync(Guid guid);

        /// <summary>
        /// 添加域名分类
        /// </summary>
        Task<Guid> CreateAsync(DomainTypeCreateRequest request);

        /// <summary>
        /// 修改域名分类
        /// </summary>
        Task UpdateAsync(DomainTypeUpdateRequest request);

        /// <summary>
        /// 删除域名分类
        /// </summary>
        Task DeleteDomainType(string ids);

    }
}