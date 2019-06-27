using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Members.Requests {
    /// <summary>
    /// 编辑下载记录数据传输对象
    /// </summary>
    public class DownloadLogUpdateRequest : RequestBase {
        /// <summary>
        /// 下载记录标识
        /// </summary>
        [Required(ErrorMessage = "下载记录标识不能为空")]
        [Display( Name = "下载记录标识" )]
        public Guid DownloadLogId { get; set; }
        /// <summary>
        /// 代理标识
        /// </summary>
        [Display( Name = "代理标识" )]
        public Guid? AgentId { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        [StringLength( 20, ErrorMessage = "IP输入过长，不能超过20位" )]
        [Display( Name = "IP" )]
        public string IPAddress { get; set; }
        /// <summary>
        /// 设备系统
        /// </summary>
        [Display( Name = "设备系统" )]
        public int? ClientOS { get; set; }
        /// <summary>
        /// 设备硬件号
        /// </summary>
        [StringLength( 100, ErrorMessage = "设备硬件号输入过长，不能超过100位" )]
        [Display( Name = "设备硬件号" )]
        public string ClientCode { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Display( Name = "创建时间" )]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [Display( Name = "创建人" )]
        public Guid? CreatorId { get; set; }
        /// <summary>
        /// 最后修改时间
        /// </summary>
        [Display( Name = "最后修改时间" )]
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 最后修改人
        /// </summary>
        [Display( Name = "最后修改人" )]
        public Guid? LastModifierId { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        [Display( Name = "版本号" )]
        public Byte[] Version { get; set; }
    }
}