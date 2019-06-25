using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Finances.Domain.Models;

namespace Agents.Data.Mappings.Finances.SqlServer {
    /// <summary>
    /// 账户映射配置
    /// </summary>
    public class AccountMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Account> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Account> builder ) {
            builder.ToTable( "Account", "Finances" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Account> builder ) {
            //账户标识
            builder.Property(t => t.Id)
                .HasColumnName("AccountId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
