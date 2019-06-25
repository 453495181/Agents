using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Members {
    /// <summary>
    /// 会员查询参数
    /// </summary>
    public class MemberQuery : QueryParameter {
        /// <summary>
        /// 会员标识
        /// </summary>
        [Display(Name="会员标识")]
        public Guid? MemberId { get; set; }
        
        private string _memberOutId = string.Empty;
        /// <summary>
        /// 会员外部标识
        /// </summary>
        [Display(Name="会员外部标识")]
        public string MemberOutId {
            get => _memberOutId == null ? string.Empty : _memberOutId.Trim();
            set => _memberOutId = value;
        }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display(Name="代理标识")]
        public Guid? AgentId { get; set; }
        
        private string _agentPath = string.Empty;
        /// <summary>
        /// 代理路径
        /// </summary>
        [Display(Name="代理路径")]
        public string AgentPath {
            get => _agentPath == null ? string.Empty : _agentPath.Trim();
            set => _agentPath = value;
        }
        
        private string _name = string.Empty;
        /// <summary>
        /// 姓名
        /// </summary>
        [Display(Name="姓名")]
        public string Name {
            get => _name == null ? string.Empty : _name.Trim();
            set => _name = value;
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
        
        private string _iPAddress = string.Empty;
        /// <summary>
        /// IP
        /// </summary>
        [Display(Name="IP")]
        public string IPAddress {
            get => _iPAddress == null ? string.Empty : _iPAddress.Trim();
            set => _iPAddress = value;
        }
        /// <summary>
        /// 类型
        /// </summary>
        [Display(Name="类型")]
        public int? Type { get; set; }
        /// <summary>
        /// 起始会员到期时间
        /// </summary>
        [Display( Name = "起始会员到期时间" )]
        public DateTime? BeginVipEndTime { get; set; }
        /// <summary>
        /// 结束会员到期时间
        /// </summary>
        [Display( Name = "结束会员到期时间" )]
        public DateTime? EndVipEndTime { get; set; }
        /// <summary>
        /// 设备系统
        /// </summary>
        [Display(Name="设备系统")]
        public int? ClientOS { get; set; }
        
        private string _clientCode = string.Empty;
        /// <summary>
        /// 设备硬件号
        /// </summary>
        [Display(Name="设备硬件号")]
        public string ClientCode {
            get => _clientCode == null ? string.Empty : _clientCode.Trim();
            set => _clientCode = value;
        }
        /// <summary>
        /// 消费总额
        /// </summary>
        [Display(Name="消费总额")]
        public decimal? ConsumptionTotal { get; set; }
        /// <summary>
        /// 起始首次访问时间
        /// </summary>
        [Display( Name = "起始首次访问时间" )]
        public DateTime? BeginFirstTime { get; set; }
        /// <summary>
        /// 结束首次访问时间
        /// </summary>
        [Display( Name = "结束首次访问时间" )]
        public DateTime? EndFirstTime { get; set; }
        /// <summary>
        /// 起始注册时间
        /// </summary>
        [Display( Name = "起始注册时间" )]
        public DateTime? BeginRegisterTime { get; set; }
        /// <summary>
        /// 结束注册时间
        /// </summary>
        [Display( Name = "结束注册时间" )]
        public DateTime? EndRegisterTime { get; set; }
        
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
}