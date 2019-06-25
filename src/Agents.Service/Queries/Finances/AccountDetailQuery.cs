using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Finances {
    /// <summary>
    /// 账户明细查询参数
    /// </summary>
    public class AccountDetailQuery : QueryParameter {
        /// <summary>
        /// 账户明细标识
        /// </summary>
        [Display(Name="账户明细标识")]
        public Guid? AccountDetailId { get; set; }
        /// <summary>
        /// 账户标识
        /// </summary>
        [Display(Name="账户标识")]
        public Guid? AccountId { get; set; }
        
        private string _tradeType = string.Empty;
        /// <summary>
        /// 交易类型
        /// </summary>
        [Display(Name="交易类型")]
        public string TradeType {
            get => _tradeType == null ? string.Empty : _tradeType.Trim();
            set => _tradeType = value;
        }
        /// <summary>
        /// 交易前余额
        /// </summary>
        [Display(Name="交易前余额")]
        public decimal? BeforeBalance { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [Display(Name="交易金额")]
        public decimal? TradeMoney { get; set; }
        /// <summary>
        /// 交易后余额
        /// </summary>
        [Display(Name="交易后余额")]
        public decimal? AfterBalance { get; set; }
        /// <summary>
        /// 起始交易时间
        /// </summary>
        [Display( Name = "起始交易时间" )]
        public DateTime? BeginTradeTime { get; set; }
        /// <summary>
        /// 结束交易时间
        /// </summary>
        [Display( Name = "结束交易时间" )]
        public DateTime? EndTradeTime { get; set; }
        
        private string _businessId = string.Empty;
        /// <summary>
        /// 业务编号
        /// </summary>
        [Display(Name="业务编号")]
        public string BusinessId {
            get => _businessId == null ? string.Empty : _businessId.Trim();
            set => _businessId = value;
        }
        
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