using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Agents.Agents.Domain.Enums;
using Util;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Agents
{
    /// <summary>
    /// 提现数据传输对象
    /// </summary>
    public class OutCashDto : DtoBase
    {
        /// <summary>
        /// 代理标识
        /// </summary>
        [Required(ErrorMessage = "代理标识不能为空")]
        [Display(Name = "代理标识")]
        public Guid AgentId { get; set; }

        /// <summary>
        /// 代理
        /// </summary>
        [Display(Name = "代理")]
        public string OutCashAgentName { get; set; }


        /// <summary>
        /// 提现金额
        /// </summary>
        [Required(ErrorMessage = "提现金额不能为空")]
        [Display(Name = "提现金额")]
        public decimal Money { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(500, ErrorMessage = "备注输入过长，不能超过500位")]
        [Display(Name = "备注")]
        public string Note { get; set; }
        /// <summary>
        /// 支付类型
        /// </summary>
        [Required(ErrorMessage = "支付类型不能为空")]
        [Display(Name = "支付类型")]
        public OutCashPayType PayType { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [Display(Name = "支付类型")]
        public string PayTypeName  => PayType.Description();

        /// <summary>
        /// 用户卡号
        /// </summary>
        [Required(ErrorMessage = "用户卡号不能为空")]
        [StringLength(200, ErrorMessage = "用户卡号输入过长，不能超过200位")]
        [Display(Name = "用户卡号")]
        public string CardId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display(Name = "状态")]
        public OutCashState State { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public string StateName => State.Description();
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