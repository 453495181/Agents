using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Finances.Domain.Models;

namespace Agents.Data.Mappings.Finances.SqlServer {
    /// <summary>
    /// 账户明细映射配置
    /// </summary>
    public class AccountDetailMap : Util.Datas.Ef.SqlServer.AggregateRootMap<AccountDetail> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<AccountDetail> builder ) {
            builder.ToTable( "AccountDetail", "Finances" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<AccountDetail> builder ) {
            //账户明细标识
            builder.Property(t => t.Id)
                .HasColumnName("AccountDetailId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
