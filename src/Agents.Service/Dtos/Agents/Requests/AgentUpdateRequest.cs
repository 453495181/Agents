using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Agents.Agents.Domain.Enums;
using Util;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Agents.Requests {
    /// <summary>
    /// 代理数据传输对象
    /// </summary>
    public class AgentUpdateRequest : RequestBase {

        /// <summary>
        /// 代理标识
        /// </summary>
        [Required(ErrorMessage = "代理标识不能为空")]
        [Display(Name = "代理标识")]
        public Guid AgentId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(ErrorMessage = "姓名不能为空")]
        [StringLength(200, ErrorMessage = "姓名输入过长，不能超过200位")]
        [Display(Name = "姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [StringLength(200, ErrorMessage = "支付宝帐号输入过长，不能超过200位")]
        [Display(Name = "支付宝帐号")]
        public string AlipayAccount { get; set; }
        /// <summary>
        /// 个人微信号
        /// </summary>
        [StringLength(200, ErrorMessage = "个人微信号输入过长，不能超过200位")]
        [Display(Name = "个人微信号")]
        public string WeChatAccount { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(ErrorMessage = "邮箱不能为空")]
        [StringLength(200, ErrorMessage = "邮箱输入过长，不能超过200位")]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        [Display(Name = "开户银行")]
        public BankEnum? Bank { get; set; }
        /// <summary>
        /// 开户名
        /// </summary>
        [StringLength(20, ErrorMessage = "开户名输入过长，不能超过20位")]
        [Display(Name = "开户名")]
        public string BankUser { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        [StringLength(50, ErrorMessage = "银行卡号输入过长，不能超过50位")]
        [Display(Name = "银行卡号")]
        public string BankNumber { get; set; }
        /// <summary>
        /// 联系QQ
        /// </summary>
        [StringLength(12, ErrorMessage = "联系QQ输入过长，不能超过12位")]
        [Display(Name = "联系QQ")]
        public string Qq { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(500, ErrorMessage = "备注输入过长，不能超过500位")]
        [Display(Name = "备注")]
        public string Note { get; set; }
    }
}


