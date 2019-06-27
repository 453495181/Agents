
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;

namespace Agents.Agents.Domain.Services.Abstractions {
    /// <summary>
    /// 提现管理器
    /// </summary>
    public interface IOutCashManager {

        /// <summary>
        /// 添加提现
        /// </summary>
        Task<OutCash> CreateOutCashAsync(OutCash model);
				
        /// <summary>
        /// 修改提现
        /// </summary>
        Task UpdateOutCash(OutCash model);

        /// <summary>
        /// 删除提现
        /// </summary>
        Task DeleteOutCash(string ids);
    }
}