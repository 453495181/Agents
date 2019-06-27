using System;
using System.Threading.Tasks;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Services.Abstractions;
using Agents.Members.Domain.Repositories;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Dtos.Members.Extensions;
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
        public MemberService( IAgentsUnitOfWork unitOfWork, IMemberRepository memberRepository, IMemberManager memberManager)
            : base( unitOfWork, memberRepository ) {
			UnitOfWork = unitOfWork;
            MemberRepository = memberRepository;
			MemberManager = memberManager;

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
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected override IQueryBase<Member> CreateQuery( MemberQuery param ) {
            return new Query<Member>( param );
        }
		
        /// <summary>
        /// 异步获取会员
        /// </summary>
        public async Task<MemberDto> GetMemberByIdAsync(Guid id) {
            var entity = await MemberRepository.FindAsync(id);
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