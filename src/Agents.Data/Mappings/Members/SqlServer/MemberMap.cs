using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Members.Domain.Models;

namespace Agents.Data.Mappings.Members.SqlServer {
    /// <summary>
    /// 会员映射配置
    /// </summary>
    public class MemberMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Member> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Member> builder ) {
            builder.ToTable( "Member", "Members" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Member> builder ) {
            //会员标识
            builder.Property(t => t.Id)
                .HasColumnName("MemberId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
