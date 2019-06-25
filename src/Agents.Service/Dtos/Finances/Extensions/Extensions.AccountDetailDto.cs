using Util;
using Util.Maps;
using Agents.Finances.Domain.Models;

namespace Agents.Service.Dtos.Finances.Extensions {
    /// <summary>
    /// 账户明细数据传输对象扩展
    /// </summary>
    public static class AccountDetailDtoExtension {
        /// <summary>
        /// 转换为账户明细实体
        /// </summary>
        /// <param name="dto">账户明细数据传输对象</param>
        public static AccountDetail ToEntity( this AccountDetailDto dto ) {
            if ( dto == null )
                return new AccountDetail();
            return dto.MapTo( new AccountDetail( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为账户明细数据传输对象
        /// </summary>
        /// <param name="entity">账户明细实体</param>
        public static AccountDetailDto ToDto(this AccountDetail entity) {
            if( entity == null )
                return new AccountDetailDto();
            return entity.MapTo<AccountDetailDto>();
        }

    }
}