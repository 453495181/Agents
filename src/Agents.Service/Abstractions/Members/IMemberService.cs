using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Queries.Members;

namespace Agents.Service.Abstractions.Members {
    /// <summary>
    /// 会员服务
    /// </summary>
    public interface IMemberService : ICrudService<MemberDto, MemberQuery> {
	
        /// <summary>
        /// 异步获取会员
        /// </summary>
        Task<MemberDto> GetMemberByIdAsync(Guid guid);

        /// <summary>
        /// 添加会员
        /// </summary>
        Task<Guid> CreateAsync(MemberCreateRequest request);

        /// <summary>
        /// 修改会员
        /// </summary>
        Task UpdateAsync(MemberUpdateRequest request);

        /// <summary>
        /// 删除会员
        /// </summary>
        Task DeleteMember(string ids);

    }
}