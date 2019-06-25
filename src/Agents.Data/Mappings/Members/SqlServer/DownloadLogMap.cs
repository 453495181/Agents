using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Members.Domain.Models;

namespace Agents.Data.Mappings.Members.SqlServer {
    /// <summary>
    /// 下载记录映射配置
    /// </summary>
    public class DownloadLogMap : Util.Datas.Ef.SqlServer.AggregateRootMap<DownloadLog> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<DownloadLog> builder ) {
            builder.ToTable( "DownloadLog", "Members" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<DownloadLog> builder ) {
            //下载记录标识
            builder.Property(t => t.Id)
                .HasColumnName("DownloadLogId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
