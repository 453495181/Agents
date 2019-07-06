using System;
using System.ComponentModel.DataAnnotations;
using Agents.Sales.Domain.Enums;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Sales {
    /// <summary>
    /// 订单查询参数
    /// </summary>
    public class OrderQuery : QueryParameter {
        /// <summary>
        /// 订单标识
        /// </summary>
        [Display(Name = "订单标识")]
        public Guid? OrderId { get; set; }

        private string _orderOutId = string.Empty;
        /// <summary>
        /// 订单外部标识
        /// </summary>
        [Display(Name = "订单外部标识")]
        public string OrderOutId {
            get => _orderOutId == null ? string.Empty : _orderOutId.Trim();
            set => _orderOutId = value;
        }
        /// <summary>
        /// 会员标识
        /// </summary>
        [Display(Name = "会员标识")]
        public Guid? MemberId { get; set; }

        private string _memberName = string.Empty;
        /// <summary>
        /// 会员名称
        /// </summary>
        [Display(Name = "会员名称")]
        public string MemberName {
            get => _memberName == null ? string.Empty : _memberName.Trim();
            set => _memberName = value;
        }

        private string _agentName = string.Empty;
        /// <summary>
        /// 代理名称
        /// </summary>
        [Display(Name = "代理名称")]
        public string AgentName {
            get => _agentName == null ? string.Empty : _agentName.Trim();
            set => _agentName = value;
        }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal? Money { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name = "类型")]
        public OrderType? Type { get; set; }

        private string _goodsName = string.Empty;
        /// <summary>
        /// 商品名称
        /// </summary>
        [Display(Name = "商品名称")]
        public string GoodsName {
            get => _goodsName == null ? string.Empty : _goodsName.Trim();
            set => _goodsName = value;
        }
        /// <summary>
        /// 支付方式
        /// </summary>
        [Display(Name = "支付方式")]
        public PayType? PayType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public OrderState? State { get; set; }
        /// <summary>
        /// 起始下单时间
        /// </summary>
        [Display(Name = "起始下单时间")]
        public DateTime? BeginOrderTime { get; set; }
        /// <summary>
        /// 结束下单时间
        /// </summary>
        [Display(Name = "结束下单时间")]
        public DateTime? EndOrderTime { get; set; }
        /// <summary>
        /// 起始付款时间
        /// </summary>
        [Display(Name = "起始付款时间")]
        public DateTime? BeginPayTime { get; set; }
        /// <summary>
        /// 结束付款时间
        /// </summary>
        [Display(Name = "结束付款时间")]
        public DateTime? EndPayTime { get; set; }

        private string _extend = string.Empty;
        /// <summary>
        /// 扩展字段
        /// </summary>
        [Display(Name = "扩展字段")]
        public string Extend {
            get => _extend == null ? string.Empty : _extend.Trim();
            set => _extend = value;
        }

        private string _note = string.Empty;
        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Note {
            get => _note == null ? string.Empty : _note.Trim();
            set => _note = value;
        }
        /// <summary>
        /// 起始创建时间
        /// </summary>
        [Display(Name = "起始创建时间")]
        public DateTime? BeginCreationTime { get; set; }
        /// <summary>
        /// 结束创建时间
        /// </summary>
        [Display(Name = "结束创建时间")]
        public DateTime? EndCreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display(Name = "创建人")]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 起始最后修改时间
        /// </summary>
        [Display(Name = "起始最后修改时间")]
        public DateTime? BeginLastModificationTime { get; set; }
        /// <summary>
        /// 结束最后修改时间
        /// </summary>
        [Display(Name = "结束最后修改时间")]
        public DateTime? EndLastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display(Name = "最后修改人")]
        public Guid? LastModifierId { get; set; }
    }
}