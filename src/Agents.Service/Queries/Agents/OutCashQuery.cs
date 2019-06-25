using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Agents {
    /// <summary>
    /// 提现查询参数
    /// </summary>
    public class OutCashQuery : QueryParameter {
        /// <summary>
        /// 账户标识
        /// </summary>
        [Display(Name="账户标识")]
        public Guid? OutCashId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display(Name="代理标识")]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// 提现金额
        /// </summary>
        [Display(Name="提现金额")]
        public decimal? Money { get; set; }
        
        private string _note = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name="备注")]
        public string Note {
            get => _note == null ? string.Empty : _note.Trim();
            set => _note = value;
        }
        /// <summary>
        /// 支付类型
        /// </summary>
        [Display(Name="支付类型")]
        public int? PayType { get; set; }
        
        private string _cardId = string.Empty;
        /// <summary>
        /// 用户卡号
        /// </summary>
        [Display(Name="用户卡号")]
        public string CardId {
            get => _cardId == null ? string.Empty : _cardId.Trim();
            set => _cardId = value;
        }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? State { get; set; }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display( Name = "起始创建时间" )]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display( Name = "结束创建时间" )]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name="创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display( Name = "起始最后修改时间" )]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display( Name = "结束最后修改时间" )]
        public DateTime? EndLastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name="最后修改人")]
        public Guid? LastModifierId { get; set; }
    }
}