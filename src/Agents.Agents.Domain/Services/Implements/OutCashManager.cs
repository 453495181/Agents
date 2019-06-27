
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
    /// ���ֹ�����
    /// </summary>
    public class OutCashManager : DomainServiceBase, IOutCashManager
    {

        /// <summary>
        /// ��ʼ�����ֹ�����
        /// </summary>
        /// <param name="outCashRepository">���ֲִ�</param>
        public OutCashManager(IOutCashRepository outCashRepository)
        {
            OutCashRepository = outCashRepository;
        }

        /// <summary>
        /// ���ֲִ�
        /// </summary>
        public IOutCashRepository OutCashRepository { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        public async Task<OutCash> CreateOutCashAsync(OutCash model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// �޸�����
        /// </summary>
        public async Task UpdateOutCash(OutCash model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ɾ������
        /// </summary>
        public async Task DeleteOutCash(string ids)
        {
            var entitis = await OutCashRepository.FindByIdsAsync(ids);
            await OutCashRepository.RemoveAsync(entitis);
        }

    }
}