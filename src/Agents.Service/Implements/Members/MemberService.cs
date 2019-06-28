using System;
using System.Linq;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Data.Conditions;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Services.Abstractions;
using Agents.Members.Domain.Repositories;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Dtos.Members.Extensions;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;
using Microsoft.EntityFrameworkCore;
using Util.Datas.Ef;

namespace Agents.Service.Implements.Members {
    /// <summary>
    /// 会员服务
    /// </summary>
    public class MemberService : CrudServiceBase<Member, MemberDto, MemberQuery>, IMemberService {
        /// <summary>
        /// 初始化会员服务
        /// </summary>
        public MemberService(IAgentsUnitOfWork unitOfWork, IMemberRepository memberRepository, IMemberManager memberManager, IAgentManager agentManager)
            : base(unitOfWork, memberRepository) {
            UnitOfWork = unitOfWork;
            MemberRepository = memberRepository;
            MemberManager = memberManager;
            AgentManager = agentManager;
        }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// 会员仓储
        /// </summary>
        public IMemberRepository MemberRepository { get; set; }

        /// <summary>
        /// 会员管理器
        /// </summary>
        public IMemberManager MemberManager { get; set; }

        /// <summary>
        /// 代理管理器
        /// </summary>
        public IAgentManager AgentManager { get; }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public PagerList<MemberDto> PagerQuery222(MemberQuery parameter) {
            if (parameter == null)
                return new PagerList<MemberDto>();
            var query = CreateQuery(parameter);
            var queryable = Filter(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected IQueryBase<Member> CreateQuery(MemberQuery param) {
            Agent currentAgent = AgentManager.GetCurrentAgentAsync();
            var memberQueryCondition = new MemberQueryCondition(currentAgent);
            return new Query<Member>(param)
                .Where(memberQueryCondition)
                .WhereIfNotEmpty(t => t.Agent.Code == param.AgentIntCode)
                .WhereIfNotEmpty(t => t.Name.Contains(param.Name))
                .WhereIfNotEmpty(t => t.MemberOutId == param.MemberOutId);
        }


        /// <summary>
        /// 过滤
        /// </summary>
        private IQueryable<Member> Filter(IQueryBase<Member> query) {
            return IsTracking ? MemberRepository.Find().Where(query) : MemberRepository.FindAsNoTracking().Where(query);
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<Member> Filter(IQueryable<Member> queryable, MemberQuery parameter) {
            return queryable.Include(t => t.Agent);
        }

        /// <summary>
        /// 异步获取会员
        /// </summary>
        public async Task<MemberDto> GetMemberByIdAsync(Guid id) {
            var entity = await MemberRepository.Find(t => t.Id == id).Include(t => t.Agent).FirstOrDefaultAsync();
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加会员
        /// </summary>
        public async Task<Guid> CreateAsync(MemberCreateRequest request) {
            var member = request.MapTo<Member>();
            member = await MemberManager.CreateMemberAsync(member);
            await UnitOfWork.CommitAsync();
            return member.Id;
        }

        /// <summary>
        /// 修改会员
        /// </summary>
        public async Task UpdateAsync(MemberUpdateRequest request) {
            var entity = await MemberRepository.FindAsync(request.MemberId);
            request.MapTo(entity);
            await MemberRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除会员
        /// </summary>
        public async Task DeleteMember(string ids) {
            await MemberManager.DeleteMember(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}