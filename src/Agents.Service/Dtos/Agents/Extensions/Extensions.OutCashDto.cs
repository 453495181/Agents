using Util;
using Util.Maps;
using Agents.Agents.Domain.Models;

namespace Agents.Service.Dtos.Agents.Extensions {
    /// <summary>
    /// 提现数据传输对象扩展
    /// </summary>
    public static class OutCashDtoExtension {
        /// <summary>
        /// 转换为提现实体
        /// </summary>
        /// <param name="dto">提现数据传输对象</param>
        public static OutCash ToEntity( this OutCashDto dto ) {
            if ( dto == null )
                return new OutCash();
            return dto.MapTo( new OutCash( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为提现数据传输对象
        /// </summary>
        /// <param name="entity">提现实体</param>
        public static OutCashDto ToDto(this OutCash entity) {
            if( entity == null )
                return new OutCashDto();
            return entity.MapTo<OutCashDto>();
        }

    }
}