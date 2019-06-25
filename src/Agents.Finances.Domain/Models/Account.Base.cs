using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Finances.Domain.Models {
    /// <summary>
    /// 账户
    /// </summary>
    [DisplayName( "账户" )]
    public partial class Account : AggregateRoot<Account>,IDelete,IAudited {
        /// <summary>
        /// 初始化账户
        /// </summary>
        public Account() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化账户
        /// </summary>
        /// <param name="id">账户标识</param>
        public Account( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 余额
        /// </summary>
        [DisplayName( "余额" )]
        [Required(ErrorMessage = "余额不能为空")]
        public decimal Balance { get; set; }
        /// <summary>
        /// 冻结余额
        /// </summary>
        [DisplayName( "冻结余额" )]
        public decimal? FreezeBalance { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        public bool Enabled { get; set; }
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
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.Balance );
            AddDescription( t => t.FreezeBalance );
            AddDescription( t => t.Enabled );
            AddDescription( t => t.Note );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Account other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Balance, other.Balance );
            AddChange( t => t.FreezeBalance, other.FreezeBalance );
            AddChange( t => t.Enabled, other.Enabled );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}