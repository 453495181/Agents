using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Agents.Agents.Domain.Enums;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;

namespace Agents.Agents.Domain.Models {
    /// <summary>
    /// 代理
    /// </summary>
    [DisplayName( "代理" )]
    public partial class Agent : AggregateRoot<Agent>,IDelete,IAudited {
        /// <summary>
        /// 初始化代理
        /// </summary>
        public Agent() : this( Guid.Empty ) {
        }

        /// <summary>
        /// 初始化代理
        /// </summary>
        /// <param name="id">代理标识</param>
        public Agent( Guid id ) : base( id ) {
        }

        /// <summary>
        /// 编码
        /// </summary>
        [DisplayName( "编码" )]
        [Required(ErrorMessage = "编码不能为空")]
        [StringLength( 20, ErrorMessage = "编码输入过长，不能超过20位" )]
        public string Code { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName( "姓名" )]
        [Required(ErrorMessage = "姓名不能为空")]
        [StringLength( 200, ErrorMessage = "姓名输入过长，不能超过200位" )]
        public string Name { get; set; }
        /// <summary>
        /// 上级代理标识
        /// </summary>
        [DisplayName( "上级代理标识" )]
        public Guid? ParentId { get; set; }
        /// <summary>
        /// 代理路径
        /// </summary>
        [DisplayName( "代理路径" )]
        [StringLength( 200, ErrorMessage = "代理路径输入过长，不能超过200位" )]
        public string AgentPath { get; set; }
        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [DisplayName( "支付宝帐号" )]
        [StringLength( 200, ErrorMessage = "支付宝帐号输入过长，不能超过200位" )]
        public string AlipayAccount { get; set; }
        /// <summary>
        /// 个人微信号
        /// </summary>
        [DisplayName( "个人微信号" )]
        [StringLength( 200, ErrorMessage = "个人微信号输入过长，不能超过200位" )]
        public string WeChatAccount { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [DisplayName( "邮箱" )]
        [StringLength( 200, ErrorMessage = "邮箱输入过长，不能超过200位" )]
        public string Email { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        [DisplayName( "手机" )]
        [Required(ErrorMessage = "手机不能为空")]
        [StringLength( 20, ErrorMessage = "手机输入过长，不能超过20位" )]
        public string Mobile { get; set; }
        /// <summary>
        /// 开户银行
        /// </summary>
        [DisplayName( "开户银行" )]
        public int? Bank { get; set; }
        /// <summary>
        /// 开户名
        /// </summary>
        [DisplayName( "开户名" )]
        [StringLength( 20, ErrorMessage = "开户名输入过长，不能超过20位" )]
        public string BankUser { get; set; }
        /// <summary>
        /// 银行卡号
        /// </summary>
        [DisplayName( "银行卡号" )]
        [StringLength( 50, ErrorMessage = "银行卡号输入过长，不能超过50位" )]
        public string BandNumber { get; set; }
        /// <summary>
        /// 联系QQ
        /// </summary>
        [DisplayName( "联系QQ" )]
        [StringLength( 12, ErrorMessage = "联系QQ输入过长，不能超过12位" )]
        public string Qq { get; set; }
        /// <summary>
        /// 启用
        /// </summary>
        [DisplayName( "启用" )]
        public bool Enabled { get; set; }
        /// <summary>
        /// 提现总额
        /// </summary>
        [DisplayName( "提现总额" )]
        public decimal? CashOutTotal { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName( "备注" )]
        [StringLength( 500, ErrorMessage = "备注输入过长，不能超过500位" )]
        public string Note { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName( "状态" )]
        [Required(ErrorMessage = "状态不能为空")]
        public AgentState State { get; set; }
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
            AddDescription( t => t.Code );
            AddDescription( t => t.Name );
            AddDescription( t => t.ParentId );
            AddDescription( t => t.AgentPath );
            AddDescription( t => t.AlipayAccount );
            AddDescription( t => t.WeChatAccount );
            AddDescription( t => t.Email );
            AddDescription( t => t.Mobile );
            AddDescription( t => t.Bank );
            AddDescription( t => t.BankUser );
            AddDescription( t => t.BandNumber );
            AddDescription( t => t.Qq );
            AddDescription( t => t.Enabled );
            AddDescription( t => t.CashOutTotal );
            AddDescription( t => t.Note );
            AddDescription( t => t.State );
            AddDescription( t => t.CreationTime );
            AddDescription( t => t.CreatorId );
            AddDescription( t => t.LastModificationTime );
            AddDescription( t => t.LastModifierId );
        }
        
        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges( Agent other ) {
            AddChange( t => t.Id, other.Id );
            AddChange( t => t.Code, other.Code );
            AddChange( t => t.Name, other.Name );
            AddChange( t => t.ParentId, other.ParentId );
            AddChange( t => t.AgentPath, other.AgentPath );
            AddChange( t => t.AlipayAccount, other.AlipayAccount );
            AddChange( t => t.WeChatAccount, other.WeChatAccount );
            AddChange( t => t.Email, other.Email );
            AddChange( t => t.Mobile, other.Mobile );
            AddChange( t => t.Bank, other.Bank );
            AddChange( t => t.BankUser, other.BankUser );
            AddChange( t => t.BandNumber, other.BandNumber );
            AddChange( t => t.Qq, other.Qq );
            AddChange( t => t.Enabled, other.Enabled );
            AddChange( t => t.CashOutTotal, other.CashOutTotal );
            AddChange( t => t.Note, other.Note );
            AddChange( t => t.State, other.State );
            AddChange( t => t.CreationTime, other.CreationTime );
            AddChange( t => t.CreatorId, other.CreatorId );
            AddChange( t => t.LastModificationTime, other.LastModificationTime );
            AddChange( t => t.LastModifierId, other.LastModifierId );
        }
    }
}