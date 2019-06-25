using Util;
using Util.Maps;
using Agents.Distributions.Domain.Models;

namespace Agents.Service.Dtos.Distributions.Extensions {
    /// <summary>
    /// 域名数据传输对象扩展
    /// </summary>
    public static class DomainDtoExtension {
        /// <summary>
        /// 转换为域名实体
        /// </summary>
        /// <param name="dto">域名数据传输对象</param>
        public static Domain ToEntity( this DomainDto dto ) {
            if ( dto == null )
                return new Domain();
            return dto.MapTo( new Domain( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为域名数据传输对象
        /// </summary>
        /// <param name="entity">域名实体</param>
        public static DomainDto ToDto(this Domain entity) {
            if( entity == null )
                return new DomainDto();
            return entity.MapTo<DomainDto>();
        }

    }
}