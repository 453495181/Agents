using System.ComponentModel;
using Util;

namespace Agents.Agents.Domain.Enums {
    /// <summary>
    /// 代理审批状态
    /// </summary>
    public enum BankEnum {
        /// <summary>
        /// 招商银行
        /// </summary>
        [Description("招商银行")] CMB = 0,
        /// <summary>
        /// 建设银行
        /// </summary>
        [Description("建设银行")] CCB = 1,
        /// <summary>
        /// 交通银行
        /// </summary>
        [Description("交通银行")] COM = 2,
        /// <summary>
        /// 邮政储蓄银行
        /// </summary>
        [Description("邮政储蓄银行")] CPG = 3,
        /// <summary>
        /// 工商银行
        /// </summary>
        [Description("工商银行")] ICBC = 4,
        /// <summary>
        /// 农业银行
        /// </summary>
        [Description("农业银行")] ABC = 5,
        /// <summary>
        /// 中国银行
        /// </summary>
        [Description("中国银行")] BOC = 6,
        /// <summary>
        /// 中信银行
        /// </summary>
        [Description("中信银行")] CITIC = 7,
        /// <summary>
        /// 光大银行
        /// </summary>
        [Description("光大银行")] CEB = 8,
        /// <summary>
        /// 华夏银行
        /// </summary>
        [Description("华夏银行")] HXB = 9,
        /// <summary>
        /// 民生银行
        /// </summary>
        [Description("民生银行")] CMSB = 10,
        /// <summary>
        /// 广发银行
        /// </summary>
        [Description("广发银行")] CGB = 11,
        /// <summary>
        /// 平安银行
        /// </summary>
        [Description("平安银行")] SZD = 12,
    }
}
