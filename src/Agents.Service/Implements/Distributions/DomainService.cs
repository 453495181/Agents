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
    /// 域名服务
    /// </summary>
    public class DomainService : DeleteServiceBase<Domain, DomainDto, DomainQuery>, IDomainService {
        /// <summary>
        /// 初始化域名服务
        /// </summary>
        public DomainService( IAgentsUnitOfWork unitOfWork, IDomainRepository domainRepository, IDomainManager domainManager)
            : base( unitOfWork, domainRepository ) {
			UnitOfWork = unitOfWork;
            DomainRepository = domainRepository;
			DomainManager = domainManager;

        }
        
        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 域名仓储
        /// </summary>
        public IDomainRepository DomainRepository { get; set; }
        
        /// <summary>
        /// 域名管理器
        /// </summary>
        public IDomainManager DomainManager { get; set; }
		

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public async Task<PagerList<DomainDto>> PagerQueryDomainAsync(DomainQuery parameter) {
            if (parameter == null)
                return new PagerList<DomainDto>();
            var query = await CreateQuery(parameter);
            var queryable =  DomainRepository.FindAsNoTracking().Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected new async Task<IQueryBase<Domain>> CreateQuery(DomainQuery param) {
            var queryCondition = new DomainQueryCondition();
            return new Query<Domain>(param)
                .Where(queryCondition);
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<Domain> Filter(IQueryable<Domain> queryable, DomainQuery parameter) {
            return queryable;
        }

        /// <summary>
        /// 异步获取域名
        /// </summary>
        public async Task<DomainDto> GetDomainByIdAsync(Guid id) {
            var entity = await DomainRepository.FindAsync(id);
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加域名
        /// </summary>
        public async Task<Guid> CreateAsync(DomainCreateRequest request) {
            var domain = request.MapTo<Domain>();
            domain = await DomainManager.CreateDomainAsync(domain);
            await UnitOfWork.CommitAsync();
            return domain.Id;
        }

        /// <summary>
        /// 修改域名
        /// </summary>
        public async Task UpdateAsync(DomainUpdateRequest request) {
            var entity = await DomainRepository.FindAsync(request.DomainId);
            request.MapTo(entity);
            await DomainRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除域名
        /// </summary>
        public async Task DeleteDomain(string ids) {
            await DomainManager.DeleteDomain(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}