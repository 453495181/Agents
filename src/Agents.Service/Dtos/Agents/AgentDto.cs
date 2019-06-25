using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Agents {
    /// <summary>
    /// 代理数据传输对象
    /// </summary>
    public class AgentDto : DtoBase {
        /// <summary>
        /// 编码
        /// </summary>
        [Required(ErrorMessage = "编码不能为空")]
        [StringLength( 20, ErrorMessage = "编码输入过长，不能超过20位" )]
        [Display( Name = "编码" )]
        public string Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = "姓名不能为空")]
        [StringLength( 200, ErrorMessage = "姓名输入过长，不能超过200位" )]
        [Display( Name = "姓名" )]
        public string Name { get; set; }
        /// <summary>
        /// 上级代理标识
        /// </summary>
        [Display( Name = "上级代理标识" )]
        public Guid? ParentId { get; set; }
        /// <summary>
        /// 代理路径
        /// </summary>
        [StringLength( 200, ErrorMessage = "代理路径输入过长，不能超过200位" )]
        [Display( Name = "代理路径" )]
        public string AgentPath { get; set; }
        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [StringLength( 200, ErrorMessage = "支付宝帐号输入过长，不能超过200位" )]
        [Display( Name = "支付宝帐号" )]
        public string AlipayAccount { get; set; }
        /// <summary>
        /// 个人微信号
        /// </summary>
        [StringLength( 200, ErrorMessage = "个人微信号输入过长，不能超过200位" )]
        [Display( Name = "个人微信号" )]
        public string WeChatAccount { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength( 200, ErrorMessage = "邮箱输入过长，不能超过200位" )]
        [Display( Name = "邮箱" )]
        public string Email { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [Required(ErrorMessage = "手机不能为空")]
        [StringLength( 20, ErrorMessage = "手机输入过长，不能超过20位" )]
        [Display( Name = "手机" )]
        public string Mobile { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        [Display( Name = "开户银行" )]
        public int? Bank { get; set; }
        /// <summary>
        /// 开户名
        /// </summary>
        [StringLength( 20, ErrorMessage = "开户名输入过长，不能超过20位" )]
        [Display( Name = "开户名" )]
        public string BankUser { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        [StringLength( 50, ErrorMessage = "银行卡号输入过长，不能超过50位" )]
        [Display( Name = "银行卡号" )]
        public string BandNumber { get; set; }
        /// <summary>
        /// 联系QQ
        /// </summary>
        [StringLength( 12, ErrorMessage = "联系QQ输入过长，不能超过12位" )]
        [Display( Name = "联系QQ" )]
        public string Qq { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [Display( Name = "启用" )]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 提现总额
        /// </summary>
        [Display( Name = "提现总额" )]
        public decimal? CashOutTotal { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        public string Note { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display( Name = "状态" )]
        public int State { get; set; }
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