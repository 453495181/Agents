using Util;
using Util.Maps;
using Agents.Agents.Domain.Models;

namespace Agents.Service.Dtos.Agents.Extensions {
    /// <summary>
    /// 代理数据传输对象扩展
    /// </summary>
    public static class AgentDtoExtension {
        /// <summary>
        /// 转换为代理实体
        /// </summary>
        /// <param name="dto">代理数据传输对象</param>
        public static Agent ToEntity( this AgentDto dto ) {
            if ( dto == null )
                return new Agent();
            return dto.MapTo( new Agent( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为代理数据传输对象
        /// </summary>
        /// <param name="entity">代理实体</param>
        public static AgentDto ToDto(this Agent entity) {
            if( entity == null )
                return new AgentDto();
            return entity.MapTo<AgentDto>();
        }

    }
}