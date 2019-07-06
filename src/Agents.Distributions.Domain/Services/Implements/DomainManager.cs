
using System;
using System.Threading.Tasks;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Agents.Distributions.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Distributions.Domain.Services.Implements {
    /// <summary>
    /// 域名管理器
    /// </summary>
    public class DomainManager : DomainServiceBase, IDomainManager {

		/// <summary>
        /// 初始化域名管理器
        /// </summary>
        public DomainManager(IDomainRepository domainRepository){
            DomainRepository = domainRepository;
        }

        /// <summary>
        /// 域名仓储
        /// </summary>
        public IDomainRepository DomainRepository { get; set; }

        /// <summary>
        /// 添加域名
        /// </summary>
        public async Task<Models.Domain> CreateDomainAsync(Models.Domain model) {
            model.Init();
            await DomainRepository.AddAsync(model);
            return model;
		}
		
        /// <summary>
        /// 修改域名
        /// </summary>
        public async Task UpdateDomain(Models.Domain model) {
            throw new NotImplementedException();
		}
		
        /// <summary>
        /// 删除域名
        /// </summary>
        public async Task DeleteDomain(string ids) {
            var entitis = await DomainRepository.FindByIdsAsync(ids);
            await DomainRepository.RemoveAsync(entitis);
		}
		
    }
}