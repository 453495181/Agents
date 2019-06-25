using Util.Domains.Repositories;
using Agents.Members.Domain.Models;

namespace Agents.Members.Domain.Repositories {
    /// <summary>
    /// 会员仓储
    /// </summary>
    public interface IMemberRepository : IRepository<Member> {
    }
}