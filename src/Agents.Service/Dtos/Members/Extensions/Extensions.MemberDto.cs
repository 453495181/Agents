using Util;
using Util.Maps;
using Agents.Members.Domain.Models;

namespace Agents.Service.Dtos.Members.Extensions {
    /// <summary>
    /// 会员数据传输对象扩展
    /// </summary>
    public static class MemberDtoExtension {
        /// <summary>
        /// 转换为会员实体
        /// </summary>
        /// <param name="dto">会员数据传输对象</param>
        public static Member ToEntity(this MemberDto dto) {
            if (dto == null)
                return new Member();
            return dto.MapTo(new Member(dto.Id.ToGuid()));
        }

        /// <summary>
        /// 转换为会员数据传输对象
        /// </summary>
        /// <param name="entity">会员实体</param>
        public static MemberDto ToDto(this Member entity) {
            if (entity == null)
                return new MemberDto();
            var result = entity.MapTo<MemberDto>();
            result.AgentName = entity.Agent?.Name;
            return result;
        }
    }
}