
using Agents.Agents.Domain.Enums;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using System;
using System.Threading.Tasks;
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
            model.Init();
            await OutCashRepository.AddAsync(model);

            //todo： 冻结余额

            return model;
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
            entitis.ForEach(x => x.State = OutCashState.Cancel);

            //todo： 恢复余额
        }

        public async void AuditOutCash(string id)
        {
            var entitis = await OutCashRepository.FindAsync(id);
            entitis.State = OutCashState.Agreed;

            //todo： 解冻余额，扣除余额，记录账号明细
        }

        public async void RefuseOutCash(string id)
        {
            var entitis = await OutCashRepository.FindAsync(id);
            entitis.State = OutCashState.Refuse;

            //todo： 解冻余额，恢复余额
        }
    }
}