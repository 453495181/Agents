using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Agents.Domain.Models;

namespace Agents.Data.Mappings.Agents.SqlServer {
    /// <summary>
    /// 提现映射配置
    /// </summary>
    public class OutCashMap : Util.Datas.Ef.SqlServer.AggregateRootMap<OutCash> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<OutCash> builder ) {
            builder.ToTable( "OutCash", "Agents" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<OutCash> builder ) {
            //账户标识
            builder.Property(t => t.Id)
                .HasColumnName("OutCashId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
