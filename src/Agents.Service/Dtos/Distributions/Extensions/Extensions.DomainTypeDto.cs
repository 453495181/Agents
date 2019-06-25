using Util;
using Util.Maps;
using Agents.Distributions.Domain.Models;

namespace Agents.Service.Dtos.Distributions.Extensions {
    /// <summary>
    /// 域名分类数据传输对象扩展
    /// </summary>
    public static class DomainTypeDtoExtension {
        /// <summary>
        /// 转换为域名分类实体
        /// </summary>
        /// <param name="dto">域名分类数据传输对象</param>
        public static DomainType ToEntity( this DomainTypeDto dto ) {
            if ( dto == null )
                return new DomainType();
            return dto.MapTo( new DomainType( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为域名分类数据传输对象
        /// </summary>
        /// <param name="entity">域名分类实体</param>
        public static DomainTypeDto ToDto(this DomainType entity) {
            if( entity == null )
                return new DomainTypeDto();
            return entity.MapTo<DomainTypeDto>();
        }

    }
}