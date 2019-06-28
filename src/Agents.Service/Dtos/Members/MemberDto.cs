using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Members {
    /// <summary>
    /// 会员数据传输对象
    /// </summary>
    public class MemberDto : DtoBase {
        /// <summary>
        /// 会员外部标识
        /// </summary>
        [Required(ErrorMessage = "会员外部标识不能为空")]
        [StringLength(50, ErrorMessage = "会员外部标识输入过长，不能超过50位")]
        [Display(Name = "会员外部标识")]
        public string MemberOutId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display(Name = "代理标识")]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// 上级代理
        /// </summary>
        [Display(Name = "上级代理")]
        public string AgentName { get; set; }
        /// <summary>
        /// 代理路径
        /// </summary>
        [StringLength(200, ErrorMessage = "代理路径输入过长，不能超过200位")]
        [Display(Name = "代理路径")]
        public string AgentPath { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [StringLength(200, ErrorMessage = "姓名输入过长，不能超过200位")]
        [Display(Name = "姓名")]
        public string Name { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [StringLength(20, ErrorMessage = "手机输入过长，不能超过20位")]
        [Display(Name = "手机")]
        public string Mobile { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [StringLength(20, ErrorMessage = "IP输入过长，不能超过20位")]
        [Display(Name = "IP")]
        public string IPAddress { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Required(ErrorMessage = "类型不能为空")]
        [Display(Name = "类型")]
        public int Type { get; set; }
        /// <summary>
        /// 会员到期时间
        /// </summary>
        [Display(Name = "会员到期时间")]
        public DateTime? VipEndTime { get; set; }
        /// <summary>
        /// 设备系统
        /// </summary>
        [Display(Name = "设备系统")]
        public int? ClientOS { get; set; }
        /// <summary>
        /// 设备硬件号
        /// </summary>
        [StringLength(100, ErrorMessage = "设备硬件号输入过长，不能超过100位")]
        [Display(Name = "设备硬件号")]
        public string ClientCode { get; set; }
        /// <summary>
        /// 消费总额
        /// </summary>
        [Display(Name = "消费总额")]
        public decimal? ConsumptionTotal { get; set; }
        /// <summary>
        /// 首次访问时间
        /// </summary>
        [Required(ErrorMessage = "首次访问时间不能为空")]
        [Display(Name = "首次访问时间")]
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [Required(ErrorMessage = "注册时间不能为空")]
        [Display(Name = "注册时间")]
        public DateTime RegisterTime { get; set; }
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