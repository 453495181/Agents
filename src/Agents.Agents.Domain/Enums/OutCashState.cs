using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Agents.Agents.Domain.Enums
{
    public enum OutCashState
    {
        /// <summary>
        /// 申请中
        /// </summary>
        [Description("申请中")] Apply = 1,

        /// <summary>
        /// 已拒绝
        /// </summary>
        [Description("已拒绝")] Refuse = 2,

        /// <summary>
        /// 已取消
        /// </summary>
        [Description("已取消")] Cancel = 3,

        /// <summary>
        /// 已同意
        /// </summary>
        [Description("已同意")] Agreed = 4,


        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")] Fished = 5,
    }
}
