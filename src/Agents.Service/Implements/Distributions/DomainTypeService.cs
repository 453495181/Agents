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
    /// 域名分类服务
    /// </summary>
    public class DomainTypeService : DeleteServiceBase<DomainType, DomainTypeDto, DomainTypeQuery>, IDomainTypeService {
        /// <summary>
        /// 初始化域名分类服务
        /// </summary>
        public DomainTypeService( IAgentsUnitOfWork unitOfWork, IDomainTypeRepository domainTypeRepository, IDomainTypeManager domainTypeManager)
            : base( unitOfWork, domainTypeRepository ) {
			UnitOfWork = unitOfWork;
            DomainTypeRepository = domainTypeRepository;
			DomainTypeManager = domainTypeManager;

        }
        
        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 域名分类仓储
        /// </summary>
        public IDomainTypeRepository DomainTypeRepository { get; set; }
        
        /// <summary>
        /// 域名分类管理器
        /// </summary>
        public IDomainTypeManager DomainTypeManager { get; set; }
		

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public async Task<PagerList<DomainTypeDto>> PagerQueryDomainTypeAsync(DomainTypeQuery parameter) {
            if (parameter == null)
                return new PagerList<DomainTypeDto>();
            var query = await CreateQuery(parameter);
            var queryable =  DomainTypeRepository.FindAsNoTracking().Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected new async Task<IQueryBase<DomainType>> CreateQuery(DomainTypeQuery param) {
            var queryCondition = new DomainTypeQueryCondition();
            return new Query<DomainType>(param)
                .Where(queryCondition);
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<DomainType> Filter(IQueryable<DomainType> queryable, DomainTypeQuery parameter) {
            return queryable;
        }

        /// <summary>
        /// 异步获取域名分类
        /// </summary>
        public async Task<DomainTypeDto> GetDomainTypeByIdAsync(Guid id) {
            var entity = await DomainTypeRepository.FindAsync(id);
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加域名分类
        /// </summary>
        public async Task<Guid> CreateAsync(DomainTypeCreateRequest request) {
            var domainType = request.MapTo<DomainType>();
            domainType = await DomainTypeManager.CreateDomainTypeAsync(domainType);
            await UnitOfWork.CommitAsync();
            return domainType.Id;
        }

        /// <summary>
        /// 修改域名分类
        /// </summary>
        public async Task UpdateAsync(DomainTypeUpdateRequest request) {
            var entity = await DomainTypeRepository.FindAsync(request.DomainTypeId);
            request.MapTo(entity);
            await DomainTypeRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除域名分类
        /// </summary>
        public async Task DeleteDomainType(string ids) {
            await DomainTypeManager.DeleteDomainType(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}