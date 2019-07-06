using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Distributions;
using Agents.Service.Dtos.Distributions.Requests;
using Agents.Service.Queries.Distributions;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Distributions {
    /// <summary>
    /// 域名服务
    /// </summary>
    public interface IDomainService : IDeleteService<DomainDto, DomainQuery> {
	
        /// <summary>
        /// 分页查询
        /// </summary>
        Task<PagerList<DomainDto>> PagerQueryDomainAsync(DomainQuery parameter);

        /// <summary>
        /// 异步获取域名
        /// </summary>
        Task<DomainDto> GetDomainByIdAsync(Guid guid);

        /// <summary>
        /// 添加域名
        /// </summary>
        Task<Guid> CreateAsync(DomainCreateRequest request);

        /// <summary>
        /// 修改域名
        /// </summary>
        Task UpdateAsync(DomainUpdateRequest request);

        /// <summary>
        /// 删除域名
        /// </summary>
        Task DeleteDomain(string ids);

    }
}