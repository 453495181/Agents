using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agents.Agents.Domain.Models;
using Agents.Distributions.Domain.Enums;
using Agents.Sales.Domain.Models;
using Util;
using Util.Domains;
using Util.Domains.Auditing;
using Util.Domains.Tenants;
using Util.Exceptions;

namespace Agents.Distributions.Domain.Models {
    /// <summary>
    /// 佣金
    /// </summary>
    [DisplayName("佣金")]
    public partial class Commission : AggregateRoot<Commission>, IDelete, IAudited {
        /// <summary>
        /// 初始化佣金
        /// </summary>
        public Commission() : this(Guid.Empty) {
        }

        /// <summary>
        /// 初始化佣金
        /// </summary>
        /// <param name="id">佣金标识</param>
        public Commission(Guid id) : base(id) {
        }

        /// <summary>
        /// 代理标识
        /// </summary>
        [DisplayName("代理标识")]
        [Required(ErrorMessage = "代理标识不能为空")]
        public Guid AgentId { get; set; }
        /// <summary>
        /// 订单标识
        /// </summary>
        [DisplayName("订单标识")]
        [Required(ErrorMessage = "订单标识不能为空")]
        public Guid OrderId { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [DisplayName("类型")]
        [Required(ErrorMessage = "类型不能为空")]
        public CommissionType Type { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        [DisplayName("金额")]
        [Required(ErrorMessage = "金额不能为空")]
        public decimal Money { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [DisplayName("状态")]
        [Required(ErrorMessage = "状态不能为空")]
        public CommissionState State { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        [StringLength(500, ErrorMessage = "备注输入过长，不能超过500位")]
        public string Note { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [DisplayName("创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [DisplayName("最后修改时间")]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [DisplayName("最后修改人")]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName("是否删除")]
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 代理
        /// </summary>
        [ForeignKey("AgentId")]
        public Agent Agent { get; set; }
        /// <summary>
        /// 订单
        /// </summary>
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        /// <summary>
        /// 添加描述
        /// </summary>
        protected override void AddDescriptions() {
            AddDescription(t => t.Id);
            AddDescription(t => t.AgentId);
            AddDescription(t => t.OrderId);
            AddDescription(t => t.Type);
            AddDescription(t => t.Money);
            AddDescription(t => t.State);
            AddDescription(t => t.Note);
            AddDescription(t => t.CreationTime);
            AddDescription(t => t.CreatorId);
            AddDescription(t => t.LastModificationTime);
            AddDescription(t => t.LastModifierId);
        }

        /// <summary>
        /// 添加变更列表
        /// </summary>
        protected override void AddChanges(Commission other) {
            AddChange(t => t.Id, other.Id);
            AddChange(t => t.AgentId, other.AgentId);
            AddChange(t => t.OrderId, other.OrderId);
            AddChange(t => t.Type, other.Type);
            AddChange(t => t.Money, other.Money);
            AddChange(t => t.State, other.State);
            AddChange(t => t.Note, other.Note);
            AddChange(t => t.CreationTime, other.CreationTime);
            AddChange(t => t.CreatorId, other.CreatorId);
            AddChange(t => t.LastModificationTime, other.LastModificationTime);
            AddChange(t => t.LastModifierId, other.LastModifierId);
        }

    }
}