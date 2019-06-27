
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Agents.Domain.Services.Implements {
    /// <summary>
    /// 提现管理器
    /// </summary>
    public class OutCashManager : DomainServiceBase, IOutCashManager {

        /// <summary>
        /// 添加提现
        /// </summary>
        public async Task<OutCash> CreateOutCashAsync(OutCash model) {
            throw new NotImplementedException();
		}
		
        /// <summary>
        /// 删除提现
        /// </summary>
        public async Task DeleteOutCash(string ids) {
            throw new NotImplementedException();
		}
		
        /// <summary>
        /// 修改提现
        /// </summary>
        public async Task UpdateOutCash(OutCash model) {
            throw new NotImplementedException();
		}
    }
}