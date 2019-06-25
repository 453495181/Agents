using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Members {
    /// <summary>
    /// 下载记录查询参数
    /// </summary>
    public class DownloadLogQuery : QueryParameter {
        /// <summary>
        /// 下载记录标识
        /// </summary>
        [Display(Name="下载记录标识")]
        public Guid? DownloadLogId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display(Name="代理标识")]
        public Guid? AgentId { get; set; }
        
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