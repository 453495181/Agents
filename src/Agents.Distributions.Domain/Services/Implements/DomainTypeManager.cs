
using System;
using System.Threading.Tasks;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Agents.Distributions.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Distributions.Domain.Services.Implements {
    /// <summary>
    /// 域名分类管理器
    /// </summary>
    public class DomainTypeManager : DomainServiceBase, IDomainTypeManager {

		/// <summary>
        /// 初始化域名分类管理器
        /// </summary>
        public DomainTypeManager(IDomainTypeRepository domainTypeRepository){
            DomainTypeRepository = domainTypeRepository;
        }

        /// <summary>
        /// 域名分类仓储
        /// </summary>
        public IDomainTypeRepository DomainTypeRepository { get; set; }

        /// <summary>
        /// 添加域名分类
        /// </summary>
        public async Task<DomainType> CreateDomainTypeAsync(DomainType model) {
            model.Init();
            await DomainTypeRepository.AddAsync(model);
            return model;
		}
		
        /// <summary>
        /// 修改域名分类
        /// </summary>
        public async Task UpdateDomainType(DomainType model) {
            throw new NotImplementedException();
		}
		
        /// <summary>
        /// 删除域名分类
        /// </summary>
        public async Task DeleteDomainType(string ids) {
            var entitis = await DomainTypeRepository.FindByIdsAsync(ids);
            await DomainTypeRepository.RemoveAsync(entitis);
		}
		
    }
}