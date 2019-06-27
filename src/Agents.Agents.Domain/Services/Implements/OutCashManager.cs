
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Agents.Domain.Services.Implements
{
    /// <summary>
    /// 提现管理器
    /// </summary>
    public class OutCashManager : DomainServiceBase, IOutCashManager
    {

        /// <summary>
        /// 初始化提现管理器
        /// </summary>
        /// <param name="outCashRepository">提现仓储</param>
        public OutCashManager(IOutCashRepository outCashRepository)
        {
            OutCashRepository = outCashRepository;
        }

        /// <summary>
        /// 提现仓储
        /// </summary>
        public IOutCashRepository OutCashRepository { get; set; }

        /// <summary>
        /// 添加提现
        /// </summary>
        public async Task<OutCash> CreateOutCashAsync(OutCash model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改提现
        /// </summary>
        public async Task UpdateOutCash(OutCash model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除提现
        /// </summary>
        public async Task DeleteOutCash(string ids)
        {
            var entitis = await OutCashRepository.FindByIdsAsync(ids);
            await OutCashRepository.RemoveAsync(entitis);
        }

    }
}