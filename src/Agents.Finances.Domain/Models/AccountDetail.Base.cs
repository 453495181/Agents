using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Finances.Domain.Models {
    /// <summary>
    /// 账户明细
    /// </summary>
    [DisplayName( "账户明细" )]
    public partial class AccountDetail : AggregateRoot<AccountDetail>,IDelete,IAudited {
        /// <summary>
        /// 初始化账户明细
        /// </summary>
        public AccountDetail() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化账户明细
        /// </summary>
        /// <param name="id">账户明细标识</param>
        public AccountDetail( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 账户标识
        /// </summary>
        [DisplayName( "账户标识" )]
        [Required(ErrorMessage = "账户标识不能为空")]
        public Guid AccountId { get; set; }
        /// <summary>
        /// 交易类型
        /// </summary>
        [DisplayName( "交易类型" )]
        [Required(ErrorMessage = "交易类型不能为空")]
        [StringLength( 50, ErrorMessage = "交易类型输入过长，不能超过50位" )]
        public string TradeType { get; set; }
        /// <summary>
        /// 交易前余额
        /// </summary>
        [DisplayName( "交易前余额" )]
        [Required(ErrorMessage = "交易前余额不能为空")]
        public decimal BeforeBalance { get; set; }
        /// <summary>
        /// 交易金额
        /// </summary>
        [DisplayName( "交易金额" )]
        [Required(ErrorMessage = "交易金额不能为空")]
        public decimal TradeMoney { get; set; }
        /// <summary>
        /// 交易后余额
        /// </summary>
        [DisplayName( "交易后余额" )]
        [Required(ErrorMessage = "交易后余额不能为空")]
        public decimal AfterBalance { get; set; }
        /// <summary>
        /// 交易时间
        /// </summary>
        [DisplayName( "交易时间" )]
        [Required(ErrorMessage = "交易时间不能为空")]
        public DateTime TradeTime { get; set; }
        /// <summary>
        /// 业务编号
        /// </summary>
        [DisplayName( "业务编号" )]
        [Required(ErrorMessage = "业务编号不能为空")]
        [StringLength( 50, ErrorMessage = "业务编号输入过长，不能超过50位" )]
        public string BusinessId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName( "备注" )]
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName( "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName( "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName( "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName( "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName( "是否删除" )]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        [ForeignKey( "AccountId" )]
        public Account Account { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.AccountId );
            AddDescription( t => t.TradeType );
            AddDescription( t => t.BeforeBalance );
            AddDescription( t => t.TradeMoney );
            AddDescription( t => t.AfterBalance );
            AddDescription( t => t.TradeTime );
            AddDescription( t => t.BusinessId );
            AddDescription( t => t.Note );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( AccountDetail other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.AccountId, other.AccountId );
            AddChange( t => t.TradeType, other.TradeType );
            AddChange( t => t.BeforeBalance, other.BeforeBalance );
            AddChange( t => t.TradeMoney, other.TradeMoney );
            AddChange( t => t.AfterBalance, other.AfterBalance );
            AddChange( t => t.TradeTime, other.TradeTime );
            AddChange( t => t.BusinessId, other.BusinessId );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}