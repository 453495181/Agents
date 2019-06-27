using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Agents {
    /// <summary>
    /// 代理查询参数
    /// </summary>
    public class SubAgentQuery : QueryParameter
    {
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display(Name = "代理标识")]
        public Guid? AgentId { get; set; } = Guid.Parse("97F08B03-50D4-44E4-AD12-36A4D9EF4B36");
        
        /// <summary>
        /// 编码
        /// </summary>
        [Display(Name="编码")]
        public int? Code { get;set; }
        
        private string _name = string.Empty;

        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name = "姓名")]
        public string Name
        {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
        } 

        private string _parentCode = string.Empty;

        /// <summary>
        /// 上级代理编号
        /// </summary>
        [Display(Name="上级代理编号")]
        public string ParentCode {
            get => _parentCode == null ? string.Empty : _parentCode.Trim();
            set => _parentCode = value;
        }

        private string _agentPath = string.Empty;
        /// <summary>
        /// 代理路径
        /// </summary>
        [Display(Name="代理路径")]
        public string AgentPath {
            get => _agentPath == null ? string.Empty : _agentPath.Trim();
            set => _agentPath = value;
        }
        
        private string _alipayAccount = string.Empty;
        /// <summary>
        /// 支付宝帐号
        /// </summary>
        [Display(Name="支付宝帐号")]
        public string AlipayAccount {
            get => _alipayAccount == null ? string.Empty : _alipayAccount.Trim();
            set => _alipayAccount = value;
        }
        
        private string _weChatAccount = string.Empty;
        /// <summary>
        /// 个人微信号
        /// </summary>
        [Display(Name="个人微信号")]
        public string WeChatAccount {
            get => _weChatAccount == null ? string.Empty : _weChatAccount.Trim();
            set => _weChatAccount = value;
        }
        
        private string _email = string.Empty;
        /// <summary>
        /// 邮箱
        /// </summary>
        [Display(Name="邮箱")]
        public string Email {
            get => _email == null ? string.Empty : _email.Trim();
            set => _email = value;
        }
        
        private string _mobile = string.Empty;
        /// <summary>
        /// 手机
        /// </summary>
        [Display(Name="手机")]
        public string Mobile {
            get => _mobile == null ? string.Empty : _mobile.Trim();
            set => _mobile = value;
        }
        /// <summary>
        /// 开户银行
        /// </summary>
        [Display(Name="开户银行")]
        public int? Bank { get; set; }
        
        private string _bankUser = string.Empty;
        /// <summary>
        /// 开户名
        /// </summary>
        [Display(Name="开户名")]
        public string BankUser {
            get => _bankUser == null ? string.Empty : _bankUser.Trim();
            set => _bankUser = value;
        }

        /// <summary>
        /// 查询等级
        /// </summary>
        [Display(Name = "代理等级")]
        public AgentLevel? Level { get; set; } = AgentLevel.First;

        private string _bankNumber = string.Empty;
        /// <summary>
        /// 银行卡号
        /// </summary>
        [Display(Name="银行卡号")]
        public string BankNumber {
            get => _bankNumber == null ? string.Empty : _bankNumber.Trim();
            set => _bankNumber = value;
        }
        
        private string _qq = string.Empty;
        /// <summary>
        /// 联系QQ
        /// </summary>
        [Display(Name="联系QQ")]
        public string Qq {
            get => _qq == null ? string.Empty : _qq.Trim();
            set => _qq = value;
        }
        /// <summary>
        /// 启用
        /// </summary>
        [Display(Name="启用")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// 提现总额
        /// </summary>
        [Display(Name="提现总额")]
        public decimal? CashOutTotal { get; set; }
        
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
        /// 状态
        /// </summary>
        [Display(Name="状态")]
        public int? State { get; set; }
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

    public enum AgentLevel
    {

        /// <summary>
        /// 一级代理
        /// </summary>
        [Description("一级代理")]
        First =1,

        /// <summary>
        /// 二级代理
        /// </summary>
        [Description("二级代理")]
        Second=2,


        /// <summary>
        /// 三级代理
        /// </summary>
        [Description("三级代理")]
        Third=3,

    }
}