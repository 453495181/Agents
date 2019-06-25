using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Service.Dtos.Agents;
using Agents.Service.Queries.Agents;
using Agents.Service.Abstractions.Agents;

namespace Agents.Service.Implements.Agents {
    /// <summary>
    /// 提现服务
    /// </summary>
    public class OutCashService : CrudServiceBase<OutCash, OutCashDto, OutCashQuery>, IOutCashService {
        /// <summary>
        /// 初始化提现服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="outCashRepository">提现仓储</param>
        public OutCashService( IAgentsUnitOfWork unitOfWork, IOutCashRepository outCashRepository )
            : base( unitOfWork, outCashRepository ) {
            OutCashRepository = outCashRepository;
        }
        
        /// <summary>
        /// 提现仓储
        /// </summary>
        public IOutCashRepository OutCashRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<OutCash> CreateQuery( OutCashQuery param ) {
            return new Query<OutCash>( param );
        }
    }
}