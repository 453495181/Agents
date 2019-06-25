using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Agents.Domain.Models;

namespace Agents.Data.Mappings.Agents.SqlServer {
    /// <summary>
    /// 代理映射配置
    /// </summary>
    public class AgentMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Agent> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Agent> builder ) {
            builder.ToTable( "Agent", "Agents" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Agent> builder ) {
            //代理标识
            builder.Property(t => t.Id)
                .HasColumnName("AgentId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
