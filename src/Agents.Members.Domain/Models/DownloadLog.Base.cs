using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agents.Agents.Domain.Models;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Members.Domain.Models {
    /// <summary>
    /// 下载记录
    /// </summary>
    [DisplayName( "下载记录" )]
    public partial class DownloadLog : AggregateRoot<DownloadLog>,IDelete,IAudited {
        /// <summary>
        /// 初始化下载记录
        /// </summary>
        public DownloadLog() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化下载记录
        /// </summary>
        /// <param name="id">下载记录标识</param>
        public DownloadLog( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 代理标识
        /// </summary>
        [DisplayName( "代理标识" )]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName( "IP" )]
        [StringLength( 20, ErrorMessage = "IP输入过长，不能超过20位" )]
        public string IPAddress { get; set; }
        /// <summary>
        /// 设备系统
        /// </summary>
        [DisplayName( "设备系统" )]
        public int? ClientOS { get; set; }
        /// <summary>
        /// 设备硬件号
        /// </summary>
        [DisplayName( "设备硬件号" )]
        [StringLength( 100, ErrorMessage = "设备硬件号输入过长，不能超过100位" )]
        public string ClientCode { get; set; }
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
            AddDescription( t => t.IPAddress );
            AddDescription( t => t.ClientOS );
            AddDescription( t => t.ClientCode );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( DownloadLog other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.AgentId, other.AgentId );
            AddChange( t => t.IPAddress, other.IPAddress );
            AddChange( t => t.ClientOS, other.ClientOS );
            AddChange( t => t.ClientCode, other.ClientCode );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}