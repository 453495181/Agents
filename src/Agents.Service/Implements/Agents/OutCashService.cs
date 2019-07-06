using Agents.Agents.Domain.Enums;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Data;
using Agents.Service.Abstractions.Agents;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Extensions;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Queries.Agents;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Util;
using Util.Applications;
using Util.Datas.Queries;
using Util.Domains.Repositories;
using Util.Maps;

namespace Agents.Service.Implements.Agents
{
    /// <summary>
    /// 提现服务
    /// </summary>
    public class OutCashService : CrudServiceBase<OutCash, OutCashDto, OutCashQuery>, IOutCashService
    {
        /// <summary>
        /// 初始化提现服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="outCashRepository">提现仓储</param>
        /// <param name="outCashManager">提现管理器</param>
        public OutCashService(IAgentsUnitOfWork unitOfWork, IOutCashRepository outCashRepository, IOutCashManager outCashManager)
            : base(unitOfWork, outCashRepository)
        {
            UnitOfWork = unitOfWork;
            OutCashRepository = outCashRepository;
            OutCashManager = outCashManager;

        }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 提现仓储
        /// </summary>
        public IOutCashRepository OutCashRepository { get; set; }

        /// <summary>
        /// 提现管理器
        /// </summary>
        public IOutCashManager OutCashManager { get; set; }


        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<OutCash> CreateQuery(OutCashQuery param)
        {
            return new Query<OutCash>(param);
        }

        /// <summary>
        /// 异步获取提现
        /// </summary>
        public async Task<OutCashDto> GetOutCashByIdAsync(Guid id)
        {
            var entity = await OutCashRepository.FindAsync(id);
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加提现
        /// </summary>
        public async Task<Guid> CreateAsync(OutCashCreateRequest request)
        {
            var outCash = request.MapTo<OutCash>();

            switch (request.PayType)
            {
                case OutCashPayType.Alipay:
                    outCash.CardId = request.AlipayAccount;
                    break;
                case OutCashPayType.Bank:
                    outCash.CardId = $"{request.Bank.Description()},{request.BankUser},{request.BankNumber}";
                    break;
            }


            outCash = await OutCashManager.CreateOutCashAsync(outCash);
            await UnitOfWork.CommitAsync();
            return outCash.Id;
        }

        /// <summary>
        /// 修改提现
        /// </summary>
        public async Task UpdateAsync(OutCashUpdateRequest request)
        {
            var entity = await OutCashRepository.FindAsync(request.OutCashId);
            request.MapTo(entity);
            await OutCashRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除提现
        /// </summary>
        public async Task DeleteOutCash(string ids)
        {
            await OutCashManager.DeleteOutCash(ids);
            await UnitOfWork.CommitAsync();
        }

        public async Task<PagerList<OutCashDto>> PagerQueryOutCashAsync(OutCashQuery parameter)
        {
            if (parameter == null)
            {
                return new PagerList<OutCashDto>();
            }

            var query = CreateQuery(parameter);
            var queryable = OutCashRepository.Find().Include(x => x.Agent).Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        public async Task AuditOutCash(string id)
        {
             OutCashManager.AuditOutCash(id);
        }

        /// <summary>转换为数据传输对象</summary>
        /// <param name="entity">实体</param>
        protected override OutCashDto ToDto(OutCash entity)
        {
            var dto = entity.MapTo<OutCashDto>();
            dto.OutCashAgentName = entity.Agent.Name;
            return dto;
        }

    }
}