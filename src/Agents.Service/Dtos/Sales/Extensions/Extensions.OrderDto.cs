using Util;
using Util.Maps;
using Agents.Sales.Domain.Models;

namespace Agents.Service.Dtos.Sales.Extensions {
    /// <summary>
    /// 订单数据传输对象扩展
    /// </summary>
    public static class OrderDtoExtension {
        /// <summary>
        /// 转换为订单实体
        /// </summary>
        /// <param name="dto">订单数据传输对象</param>
        public static Order ToEntity( this OrderDto dto ) {
            if ( dto == null )
                return new Order();
            return dto.MapTo( new Order( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为订单数据传输对象
        /// </summary>
        /// <param name="entity">订单实体</param>
        public static OrderDto ToDto(this Order entity) {
            if( entity == null )
                return new OrderDto();
            return entity.MapTo<OrderDto>();
        }

    }
}