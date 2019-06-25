using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Distributions.Domain.Models {
    /// <summary>
    /// 域名
    /// </summary>
    [DisplayName( "域名" )]
    public partial class Domain : AggregateRoot<Domain>,IDelete,IAudited {
        /// <summary>
        /// 初始化域名
        /// </summary>
        public Domain() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化域名
        /// </summary>
        /// <param name="id">域名标识</param>
        public Domain( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 域名分类标识
        /// </summary>
        [DisplayName( "域名分类标识" )]
        [Required(ErrorMessage = "域名分类标识不能为空")]
        public Guid DomainTypeId { get; set; }
        /// <summary>
        /// 域名
        /// </summary>
        [DisplayName( "域名" )]
        [StringLength( 500, ErrorMessage = "域名输入过长，不能超过500位" )]
        public string DomainMember { get; set; }
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
        /// 域名分类
        /// </summary>
        [ForeignKey( "DomainTypeId" )]
        public DomainType DomainType { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.DomainTypeId );
            AddDescription( t => t.DomainMember );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Domain other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.DomainTypeId, other.DomainTypeId );
            AddChange( t => t.DomainMember, other.DomainMember );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}