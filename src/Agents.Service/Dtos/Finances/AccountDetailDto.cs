using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Finances {
    /// <summary>
    /// 账户明细数据传输对象
    /// </summary>
    public class AccountDetailDto : DtoBase {
        /// <summary>
        /// 账户标识
        /// </summary>
        [Required(ErrorMessage = "账户标识不能为空")]
        [Display( Name = "账户标识" )]
        public Guid AccountId { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        [Required(ErrorMessage = "交易类型不能为空")]
        [StringLength( 50, ErrorMessage = "交易类型输入过长，不能超过50位" )]
        [Display( Name = "交易类型" )]
        public string TradeType { get; set; }
        /// <summary>
        /// 交易前余额
        /// </summary>
        [Required(ErrorMessage = "交易前余额不能为空")]
        [Display( Name = "交易前余额" )]
        public decimal BeforeBalance { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [Required(ErrorMessage = "交易金额不能为空")]
        [Display( Name = "交易金额" )]
        public decimal TradeMoney { get; set; }
        /// <summary>
        /// 交易后余额
        /// </summary>
        [Required(ErrorMessage = "交易后余额不能为空")]
        [Display( Name = "交易后余额" )]
        public decimal AfterBalance { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        [Required(ErrorMessage = "交易时间不能为空")]
        [Display( Name = "交易时间" )]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// 业务编号
        /// </summary>
        [Required(ErrorMessage = "业务编号不能为空")]
        [StringLength( 50, ErrorMessage = "业务编号输入过长，不能超过50位" )]
        [Display( Name = "业务编号" )]
        public string BusinessId { get; set; }
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