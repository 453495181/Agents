using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Agents.Domain.Models {
    /// <summary>
    /// 提现
    /// </summary>
    [DisplayName( "提现" )]
    public partial class OutCash : AggregateRoot<OutCash>,IDelete,IAudited {
        /// <summary>
        /// 初始化提现
        /// </summary>
        public OutCash() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化提现
        /// </summary>
        /// <param name="id">提现标识</param>
        public OutCash( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 代理标识
        /// </summary>
        [DisplayName( "代理标识" )]
        [Required(ErrorMessage = "代理标识不能为空")]
        public Guid AgentId { get; set; }
        /// <summary>
        /// 提现金额
        /// </summary>
        [DisplayName( "提现金额" )]
        [Required(ErrorMessage = "提现金额不能为空")]
        public decimal Money { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName( "备注" )]
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        public string Note { get; set; }
        /// <summary>
        /// 支付类型
        /// </summary>
        [DisplayName( "支付类型" )]
        [Required(ErrorMessage = "支付类型不能为空")]
        public int PayType { get; set; }
        /// <summary>
        /// 用户卡号
        /// </summary>
        [DisplayName( "用户卡号" )]
        [Required(ErrorMessage = "用户卡号不能为空")]
        [StringLength( 200, ErrorMessage = "用户卡号输入过长，不能超过200位" )]
        public string CardId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName( "状态" )]
        [Required(ErrorMessage = "状态不能为空")]
        public int State { get; set; }
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
        /// 代理
        /// </summary>
        [ForeignKey( "AgentId" )]
        public Agent Agent { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.AgentId );
            AddDescription( t => t.Money );
            AddDescription( t => t.Note );
            AddDescription( t => t.PayType );
            AddDescription( t => t.CardId );
            AddDescription( t => t.State );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( OutCash other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.AgentId, other.AgentId );
            AddChange( t => t.Money, other.Money );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.PayType, other.PayType );
            AddChange( t => t.CardId, other.CardId );
            AddChange( t => t.State, other.State );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}