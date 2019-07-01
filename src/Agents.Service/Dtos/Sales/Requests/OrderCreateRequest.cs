using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Agents.Sales.Domain.Enums;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Sales.Requests {
    /// <summary>
    /// 新增订单数据传输对象
    /// </summary>
    public class OrderCreateRequest : RequestBase {

        /// <summary>
        /// 会员外部标识
        /// </summary>
        [Required(ErrorMessage = "会员外部标识不能为空")]
        [Display(Name = "会员外部标识")]
        public string MemberOutId { get; set; }

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
        [Required(ErrorMessage = "商品名称不能为空")]
        [StringLength(100, ErrorMessage = "商品名称输入过长，不能超过100位")]
        [Display(Name = "商品名称")]
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
        /// 支付方式
        /// </summary>
        [Display(Name = "支付方式")]
        public PayType? PayType { get; set; }
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
    }
}