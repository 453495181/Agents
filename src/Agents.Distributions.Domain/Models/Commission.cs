using Agents.Distributions.Domain.Enums;
using Util.Exceptions;

namespace Agents.Distributions.Domain.Models {
    /// <summary>
    /// 佣金
    /// </summary>
    public partial class Commission {
        /// <summary>
        /// 支付佣金
        /// </summary>
        public void Pay() {
            if (State != CommissionState.UnPayed) {
                throw new Warning("错误的佣金状态");
            }
            State = CommissionState.Payed;
        }
    }
}