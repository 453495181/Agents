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
    /// 会员
    /// </summary>
    [DisplayName( "会员" )]
    public partial class Member : AggregateRoot<Member>,IDelete,IAudited {
        /// <summary>
        /// 初始化会员
        /// </summary>
        public Member() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化会员
        /// </summary>
        /// <param name="id">会员标识</param>
        public Member( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 会员外部标识
        /// </summary>
        [DisplayName( "会员外部标识" )]
        [Required(ErrorMessage = "会员外部标识不能为空")]
        [StringLength( 50, ErrorMessage = "会员外部标识输入过长，不能超过50位" )]
        public string MemberOutId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [DisplayName( "代理标识" )]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// 代理路径
        /// </summary>
        [DisplayName( "代理路径" )]
        [StringLength( 200, ErrorMessage = "代理路径输入过长，不能超过200位" )]
        public string AgentPath { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName( "姓名" )]
        [StringLength( 200, ErrorMessage = "姓名输入过长，不能超过200位" )]
        public string Name { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [DisplayName( "手机" )]
        [StringLength( 20, ErrorMessage = "手机输入过长，不能超过20位" )]
        public string Mobile { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [DisplayName( "IP" )]
        [StringLength( 20, ErrorMessage = "IP输入过长，不能超过20位" )]
        public string IPAddress { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [DisplayName( "类型" )]
        [Required(ErrorMessage = "类型不能为空")]
        public int Type { get; set; }
        /// <summary>
        /// 会员到期时间
        /// </summary>
        [DisplayName( "会员到期时间" )]
        public DateTime? VipEndTime { get; set; }
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
        /// 消费总额
        /// </summary>
        [DisplayName( "消费总额" )]
        public decimal? ConsumptionTotal { get; set; }
        /// <summary>
        /// 首次访问时间
        /// </summary>
        [DisplayName( "首次访问时间" )]
        [Required(ErrorMessage = "首次访问时间不能为空")]
        public DateTime FirstTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        [DisplayName( "注册时间" )]
        [Required(ErrorMessage = "注册时间不能为空")]
        public DateTime RegisterTime { get; set; }
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
        /// 代理
        /// </summary>
        [ForeignKey( "AgentId" )]
        public Agent Agent { get; set; }
        
        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription( t => t.Id );
            AddDescription( t => t.MemberOutId );
            AddDescription( t => t.AgentId );
            AddDescription( t => t.AgentPath );
            AddDescription( t => t.Name );
            AddDescription( t => t.Mobile );
            AddDescription( t => t.IPAddress );
            AddDescription( t => t.Type );
            AddDescription( t => t.VipEndTime );
            AddDescription( t => t.ClientOS );
            AddDescription( t => t.ClientCode );
            AddDescription( t => t.ConsumptionTotal );
            AddDescription( t => t.FirstTime );
            AddDescription( t => t.RegisterTime );
            AddDescription( t => t.Note );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Member other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.MemberOutId, other.MemberOutId );
            AddChange( t => t.AgentId, other.AgentId );
            AddChange( t => t.AgentPath, other.AgentPath );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.Mobile, other.Mobile );
            AddChange( t => t.IPAddress, other.IPAddress );
            AddChange( t => t.Type, other.Type );
            AddChange( t => t.VipEndTime, other.VipEndTime );
            AddChange( t => t.ClientOS, other.ClientOS );
            AddChange( t => t.ClientCode, other.ClientCode );
            AddChange( t => t.ConsumptionTotal, other.ConsumptionTotal );
            AddChange( t => t.FirstTime, other.FirstTime );
            AddChange( t => t.RegisterTime, other.RegisterTime );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}