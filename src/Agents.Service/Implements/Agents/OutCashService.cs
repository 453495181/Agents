using System;
using System.Threading.Tasks;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Agents.Domain.Repositories;
using Agents.Service.Dtos.Agents;
using Agents.Service.Dtos.Agents.Requests;
using Agents.Service.Dtos.Agents.Extensions;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;

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
    }
}