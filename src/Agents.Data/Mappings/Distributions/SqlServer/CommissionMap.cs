using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Distributions.Domain.Models;

namespace Agents.Data.Mappings.Distributions.SqlServer {
    /// <summary>
    /// 佣金映射配置
    /// </summary>
    public class CommissionMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Commission> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Commission> builder ) {
            builder.ToTable( "Commission", "Distributions" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Commission> builder ) {
            //佣金标识
            builder.Property(t => t.Id)
                .HasColumnName("CommissionId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
