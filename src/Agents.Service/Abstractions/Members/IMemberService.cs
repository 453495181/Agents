using System;
using System.Threading.Tasks;
using Util.Applications;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Queries.Members;
using Util.Domains.Repositories;

namespace Agents.Service.Abstractions.Members {
    /// <summary>
    /// 会员服务
    /// </summary>
    public interface IMemberService : ICrudService<MemberDto, MemberQuery> {

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        Task<PagerList<MemberDto>> PagerQueryMemberAsync(MemberQuery parameter);

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