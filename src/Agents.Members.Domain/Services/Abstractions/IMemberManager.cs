
using System;
using System.Threading.Tasks;
using Agents.Members.Domain.Models;

namespace Agents.Members.Domain.Services.Abstractions {
    /// <summary>
    /// 会员管理器
    /// </summary>
    public interface IMemberManager {

        /// <summary>
        /// 添加会员
        /// </summary>
        Task<Member> CreateMemberAsync(Member model);
		
        /// <summary>
        /// 删除会员
        /// </summary>
        Task DeleteMember(string ids);
		
        /// <summary>
        /// 修改会员
        /// </summary>
        Task UpdateMember(Member model);
    }
}