using System;
using System.ComponentModel.DataAnnotations;

namespace Agents.Service.Dtos.Agents.Requests
{
    public class SubAgentCreateRequest : AgentCreateRequest
    {
        /// <summary>
        /// 上级代理标识
        /// </summary>
        [Display(Name = "上级代理标识")]
        public Guid? ParentId { get; set; } = Guid.Parse("97F08B03-50D4-44E4-AD12-36A4D9EF4B36");

        /// <summary>
        /// 代理路径
        /// </summary>
        [StringLength(200, ErrorMessage = "代理路径输入过长，不能超过200位")]
        [Display(Name = "代理路径")]
        public string AgentPath { get; set; }


        /// <summary>
        /// 提现总额
        /// </summary>
        [Display(Name = "提现总额")]
        public decimal? CashOutTotal { get; set; } = 0;
    }
}
