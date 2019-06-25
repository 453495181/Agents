using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Agents.Sales.Domain.Models;

namespace Agents.Data.Mappings.Sales.SqlServer {
    /// <summary>
    /// 订单映射配置
    /// </summary>
    public class OrderMap : Util.Datas.Ef.SqlServer.AggregateRootMap<Order> {
        /// <summary>
        /// 映射表
        /// </summary>
        protected override void MapTable( EntityTypeBuilder<Order> builder ) {
            builder.ToTable( "Order", "Sales" );
        }
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected override void MapProperties( EntityTypeBuilder<Order> builder ) {
            //订单标识
            builder.Property(t => t.Id)
                .HasColumnName("OrderId");
            builder.HasQueryFilter( t => t.IsDeleted == false );
        }
    }
}
