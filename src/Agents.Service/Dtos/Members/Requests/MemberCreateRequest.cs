using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Members.Requests {
    /// <summary>
    /// 新增会员数据传输对象
    /// </summary>
    public class MemberCreateRequest : RequestBase {
        /// <summary>
        /// 会员外部标识
        /// </summary>
        [Required(ErrorMessage = "会员外部标识不能为空")]
        [StringLength( 50, ErrorMessage = "会员外部标识输入过长，不能超过50位" )]
        [Display( Name = "会员外部标识" )]
        public string MemberOutId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display( Name = "代理标识" )]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// 代理路径
        /// </summary>
        [StringLength( 200, ErrorMessage = "代理路径输入过长，不能超过200位" )]
        [Display( Name = "代理路径" )]
        public string AgentPath { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [StringLength( 200, ErrorMessage = "姓名输入过长，不能超过200位" )]
        [Display( Name = "姓名" )]
        public string Name { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [StringLength( 20, ErrorMessage = "手机输入过长，不能超过20位" )]
        [Display( Name = "手机" )]
        public string Mobile { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [StringLength( 20, ErrorMessage = "IP输入过长，不能超过20位" )]
        [Display( Name = "IP" )]
        public string IPAddress { get; set; }
        /// <summary>
        /// 首次访问时间
        /// </summary>
        [Required(ErrorMessage = "首次访问时间不能为空")]
        [Display( Name = "首次访问时间" )]
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [Required(ErrorMessage = "注册时间不能为空")]
        [Display( Name = "注册时间" )]
        public DateTime RegisterTime { get; set; }
    }
}