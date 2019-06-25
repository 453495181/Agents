using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Agents.Service.Dtos.Members;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;

namespace Agents.Service.Implements.Members {
    /// <summary>
    /// 会员服务
    /// </summary>
    public class MemberService : CrudServiceBase<Member, MemberDto, MemberQuery>, IMemberService {
        /// <summary>
        /// 初始化会员服务
        /// </summary>
        /// <param name="unitOfWork">工作单元</param>
        /// <param name="memberRepository">会员仓储</param>
        public MemberService( IAgentsUnitOfWork unitOfWork, IMemberRepository memberRepository )
            : base( unitOfWork, memberRepository ) {
            MemberRepository = memberRepository;
        }
        
        /// <summary>
        /// 会员仓储
        /// </summary>
        public IMemberRepository MemberRepository { get; set; }
        
        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Member> CreateQuery( MemberQuery param ) {
            return new Query<Member>( param );
        }
    }
}