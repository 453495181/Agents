using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Distributions.Domain.Models;

namespace Agents.Data.Mappings.Distributions.SqlServer {
    /// <summary>
    /// 域名分类映射配置
    /// </summary>
    public class DomainTypeMap : Util.Datas.Ef.SqlServer.AggregateRootMap<DomainType> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<DomainType> builder ) {
            builder.ToTable( "DomainType", "Distributions" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<DomainType> builder ) {
            //域名分类标识
            builder.Property(t => t.Id)
                .HasColumnName("DomainTypeId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
