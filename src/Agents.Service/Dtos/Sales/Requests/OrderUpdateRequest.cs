using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Sales.Requests {
    /// <summary>
    /// 编辑订单数据传输对象
    /// </summary>
    public class OrderUpdateRequest : RequestBase {
        /// <summary>
        /// 订单标识
        /// </summary>
        [Required(ErrorMessage = "订单标识不能为空")]
        [Display( Name = "订单标识" )]
        public Guid OrderId { get; set; }
        /// <summary>
        /// 会员标识
        /// </summary>
        [Required(ErrorMessage = "会员标识不能为空")]
        [Display( Name = "会员标识" )]
        public Guid MemberId { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [Required(ErrorMessage = "金额不能为空")]
        [Display( Name = "金额" )]
        public decimal Money { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [StringLength( 100, ErrorMessage = "类型输入过长，不能超过100位" )]
        [Display( Name = "类型" )]
        public string Type { get; set; }
        /// <summary>
        /// 支付方式
        /// </summary>
        [Display( Name = "支付方式" )]
        public int? PayType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display( Name = "状态" )]
        public int State { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        [Required(ErrorMessage = "下单时间不能为空")]
        [Display( Name = "下单时间" )]
        public DateTime OrderTime { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        [Display( Name = "付款时间" )]
        public DateTime? PayTime { get; set; }
        /// <summary>
        /// 扩展字段
        /// </summary>
        [Display( Name = "扩展字段" )]
        public string Extend { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        public Byte[] Version { get; set; }
    }
}