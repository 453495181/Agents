
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
            model.Init();
            await OutCashRepository.AddAsync(model);

            //todo�� �������

            return model;
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
            entitis.ForEach(x => x.State = OutCashState.Cancel);

            //todo�� �ָ����
        }

        public async void AuditOutCash(string id)
        {
            var entitis = await OutCashRepository.FindAsync(id);
            entitis.State = OutCashState.Agreed;

            //todo�� �ⶳ���۳�����¼�˺���ϸ
        }

        public async void RefuseOutCash(string id)
        {
            var entitis = await OutCashRepository.FindAsync(id);
            entitis.State = OutCashState.Refuse;

            //todo�� �ⶳ���ָ����
        }
    }
}