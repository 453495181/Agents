using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Agents.Sales.Domain.Enums;
using Util;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Sales {
    /// <summary>
    /// 订单数据传输对象
    /// </summary>
    public class OrderDto : DtoBase {
        /// <summary>
        /// 会员标识
        /// </summary>
        [Required(ErrorMessage = "会员标识不能为空")]
        [Display(Name = "会员标识")]
        public Guid MemberId { get; set; }
        /// <summary>
        /// 会员
        /// </summary>
        [Display(Name = "会员")]
        public string MemberName { get; set; }
        /// <summary>
        /// 代理
        /// </summary>
        [Display(Name = "代理")]
        public string MemberAgentName { get; set; }
        /// <summary>
        /// 订单外部标识
        /// </summary>
        [Display(Name = "订单外部标识")]
        [Required(ErrorMessage = "订单外部标识不能为空")]
        [StringLength(50, ErrorMessage = "订单外部标识输入过长，不能超过50位")]
        public string OrderOutId { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [Display(Name = "商品名称")]
        [Required(ErrorMessage = "商品名称不能为空")]
        [StringLength(100, ErrorMessage = "商品名称输入过长，不能超过100位")]
        public string GoodsName { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Required(ErrorMessage = "金额不能为空")]
        [Display(Name = "金额")]
        public decimal Money { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display(Name = "类型")]
        public OrderType Type { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name = "类型")]
        public string TypeName => Type.Description();
        /// <summary>
        /// 支付方式
        /// </summary>
        [Display(Name = "支付方式")]
        public PayType? PayType { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        [Display(Name = "支付方式")]
        public string PayTypeName => PayType.HasValue ? PayType.Description() : "";
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display(Name = "状态")]
        public OrderState State { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public string StateName => State.Description();
        /// <summary>
        /// 佣金状态
        /// </summary>
        [Required(ErrorMessage = "佣金状态不能为空")]
        [Display(Name = "佣金状态")]
        public OrderCommissionState CommissionState { get; set; }
        /// <summary>
        /// 佣金状态
        /// </summary>
        [Display(Name = "佣金状态")]
        public string CommissionStateName => CommissionState.Description();
        /// <summary>
        /// 下单时间
        /// </summary>
        [Required(ErrorMessage = "下单时间不能为空")]
        [Display(Name = "下单时间")]
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        [Display(Name = "付款时间")]
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 扩展字段
        /// </summary>
        [Display(Name = "扩展字段")]
        public string Extend { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(500, ErrorMessage = "备注输入过长，不能超过500位")]
        [Display(Name = "备注")]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display(Name = "最后修改时间")]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name = "最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display(Name = "版本号")]
        public Byte[] Version { get; set; }
    }
}