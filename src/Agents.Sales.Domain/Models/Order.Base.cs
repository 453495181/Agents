using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agents.Members.Domain.Models;
using Agents.Sales.Domain.Enums;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Sales.Domain.Models {
    /// <summary>
    /// 订单
    /// </summary>
    [DisplayName("订单")]
    public partial class Order : AggregateRoot<Order>, IDelete, IAudited {
        /// <summary>
        /// 初始化订单
        /// </summary>
        public Order() : this(Guid.Empty) {
        }

        /// <summary>
        /// 初始化订单
        /// </summary>
        /// <param name="id">订单标识</param>
        public Order(Guid id) : base(id) {
        }

        /// <summary>
        /// 订单外部标识
        /// </summary>
        [DisplayName("订单外部标识")]
        [Required(ErrorMessage = "订单外部标识不能为空")]
        [StringLength(50, ErrorMessage = "订单外部标识输入过长，不能超过50位")]
        public string OrderOutId { get; set; }
        
        /// <summary>
        /// 会员标识
        /// </summary>
        [DisplayName("会员标识")]
        [Required(ErrorMessage = "会员标识不能为空")]
        public Guid MemberId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [DisplayName("商品名称")]
        [Required(ErrorMessage = "商品名称不能为空")]
        [StringLength(100, ErrorMessage = "商品名称输入过长，不能超过100位")]
        public string GoodsName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [DisplayName("金额")]
        [Required(ErrorMessage = "金额不能为空")]
        public decimal Money { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [DisplayName("类型")]
        [Required(ErrorMessage = "类型不能为空")]
        public OrderType Type { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        [DisplayName("支付方式")]
        public PayType? PayType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态")]
        [Required(ErrorMessage = "状态不能为空")]
        public OrderState State { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        [DisplayName("下单时间")]
        [Required(ErrorMessage = "下单时间不能为空")]
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        [DisplayName("付款时间")]
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 扩展字段
        /// </summary>
        [DisplayName("扩展字段")]
        public string Extend { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        [StringLength(500, ErrorMessage = "备注输入过长，不能超过500位")]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName("最后修改时间")]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName("最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName("是否删除")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 会员
        /// </summary>
        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription(t => t.Id);
            AddDescription(t => t.MemberId);
            AddDescription(t => t.Money);
            AddDescription(t => t.Type);
            AddDescription(t => t.PayType);
            AddDescription(t => t.State);
            AddDescription(t => t.OrderTime);
            AddDescription(t => t.PayTime);
            AddDescription(t => t.Extend);
            AddDescription(t => t.Note);
            AddDescription(t => t.CreationTime);
            AddDescription(t => t.CreatorId);
            AddDescription(t => t.LastModificationTime);
            AddDescription(t => t.LastModifierId);
        }

        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges(Order other) {
            AddChange(t => t.Id, other.Id);
            AddChange(t => t.MemberId, other.MemberId);
            AddChange(t => t.Money, other.Money);
            AddChange(t => t.Type, other.Type);
            AddChange(t => t.PayType, other.PayType);
            AddChange(t => t.State, other.State);
            AddChange(t => t.OrderTime, other.OrderTime);
            AddChange(t => t.PayTime, other.PayTime);
            AddChange(t => t.Extend, other.Extend);
            AddChange(t => t.Note, other.Note);
            AddChange(t => t.CreationTime, other.CreationTime);
            AddChange(t => t.CreatorId, other.CreatorId);
            AddChange(t => t.LastModificationTime, other.LastModificationTime);
            AddChange(t => t.LastModifierId, other.LastModifierId);
        }
    }
}