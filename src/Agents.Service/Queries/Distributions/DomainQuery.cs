using System;
using System.ComponentModel.DataAnnotations;
using Util;
using Util.Datas.Queries;

namespace Agents.Service.Queries.Distributions {
    /// <summary>
    /// 域名查询参数
    /// </summary>
    public class DomainQuery : QueryParameter {
        /// <summary>
        /// 域名标识
        /// </summary>
        [Display(Name="域名标识")]
        public Guid? DomainId { get; set; }
        /// <summary>
        /// 域名分类标识
        /// </summary>
        [Display(Name="域名分类标识")]
        public Guid? DomainTypeId { get; set; }
        
        private string _domainMember = string.Empty;
        /// <summary>
        /// 域名
        /// </summary>
        [Display(Name="域名")]
        public string DomainMember {
            get => _domainMember == null ? string.Empty : _domainMember.Trim();
            set => _domainMember = value;
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