﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Util.Ui.Attributes;
using Util.Applications.Dtos;

namespace Agents.Service.Dtos.Distributions {
    /// <summary>
    /// 域名数据传输对象
    /// </summary>
    public class DomainDto : DtoBase {
        /// <summary>
        /// 域名分类标识
        /// </summary>
        [Required(ErrorMessage = "域名分类标识不能为空")]
        [Display( Name = "域名分类标识" )]
        public Guid DomainTypeId { get; set; }
        /// <summary>
        /// 域名
        /// </summary>
        [StringLength( 500, ErrorMessage = "域名输入过长，不能超过500位" )]
        [Display( Name = "域名" )]
        public string DomainMember { get; set; }
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