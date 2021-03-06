﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Agents.Agents.Domain.Enums;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Agents.Requests {
    /// <summary>
    /// 新增提现数据传输对象
    /// </summary>
    public class OutCashCreateRequest : RequestBase
    {
        /// <summary>
        /// 代理标识
        /// </summary>
        [Required(ErrorMessage = "代理标识不能为空")]
        [Display(Name = "代理标识")]
        public Guid AgentId { get; set; } = Guid.Parse("97F08B03-50D4-44E4-AD12-36A4D9EF4B36");
        /// <summary>
        /// 提现金额
        /// </summary>
        [Required(ErrorMessage = "提现金额不能为空")]
        [Display( Name = "提现金额(元)" )]
        public decimal Money { get; set; }


        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [StringLength(200, ErrorMessage = "支付宝帐号输入过长，不能超过200位")]
        [Display(Name = "支付宝帐号")]
        public string AlipayAccount { get; set; }
      
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
        /// 可提现金额
        /// </summary>
        [Display(Name = "可提现金额")]
        public decimal AbleOutMoney { get; set; } = 0;


        /// <summary>
        /// 备注
        /// </summary>
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        [Display( Name = "备注" )]
        public string Note { get; set; }
        /// <summary>
        /// 支付类型
        /// </summary>
        [Required(ErrorMessage = "支付类型不能为空")]
        [Display( Name = "支付类型" )]
        public OutCashPayType PayType { get; set; }
        /// <summary>
        /// 用户卡号
        /// </summary>
        [Required(ErrorMessage = "用户卡号不能为空")]
        [StringLength( 200, ErrorMessage = "用户卡号输入过长，不能超过200位" )]
        [Display( Name = "用户卡号" )]
        public string CardId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Required(ErrorMessage = "状态不能为空")]
        [Display(Name = "状态")]
        public OutCashState State { get; set; } = OutCashState.Apply;
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