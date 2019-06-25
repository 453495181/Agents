using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Distributions.Domain.Models;

namespace Agents.Data.Mappings.Distributions.SqlServer {
    /// <summary>
    /// 域名映射配置
    /// </summary>
    public class DomainMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Domain> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Domain> builder ) {
            builder.ToTable( "Domain", "Distributions" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Domain> builder ) {
            //域名标识
            builder.Property(t => t.Id)
                .HasColumnName("DomainId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
