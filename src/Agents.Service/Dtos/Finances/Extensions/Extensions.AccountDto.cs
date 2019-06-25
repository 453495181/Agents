using Util;
using Util.Maps;
using Agents.Finances.Domain.Models;

namespace Agents.Service.Dtos.Finances.Extensions {
    /// <summary>
    /// 账户数据传输对象扩展
    /// </summary>
    public static class AccountDtoExtension {
        /// <summary>
        /// 转换为账户实体
        /// </summary>
        /// <param name="dto">账户数据传输对象</param>
        public static Account ToEntity( this AccountDto dto ) {
            if ( dto == null )
                return new Account();
            return dto.MapTo( new Account( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为账户数据传输对象
        /// </summary>
        /// <param name="entity">账户实体</param>
        public static AccountDto ToDto(this Account entity) {
            if( entity == null )
                return new AccountDto();
            return entity.MapTo<AccountDto>();
        }

    }
}