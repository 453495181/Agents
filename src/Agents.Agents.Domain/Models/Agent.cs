using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Util.Exceptions;

namespace Agents.Agents.Domain.Models {
    /// <summary>
    /// 代理
    /// </summary>
    public partial class Agent {

        /// <summary>
        /// 初始化实体
        /// </summary>
        public override void Init() {
            base.Init();
            Enabled = true;
            State = Enums.AgentState.WatiApproval;
        }

        /// <summary>
        /// 设置编号
        /// </summary>
        public void SetCode(int maxCode) {
            if (maxCode < 100000) {
                maxCode = 100000;
            }
            Code = maxCode + 1;
        }

        /// <summary>
        /// 通过审核
        /// </summary>
        public void Approval(Guid userId) {
            if (State != Enums.AgentState.WatiApproval) {
                throw new Warning("该状态不支持此操作");
            }
            State = Enums.AgentState.Approved;
            UserId = userId;
        }
        /// <summary>
        /// 拒绝审核
        /// </summary>
        public void Refuse() {
            if (State != Enums.AgentState.WatiApproval) {
                throw new Warning("该状态不支持此操作");
            }
            State = Enums.AgentState.UnApproved;
        }

        /// <summary>
        /// 设置代理路径
        /// </summary>
        public void SetAgentPath(Agent parentAgent) {
            if (parentAgent == null)
            {
                AgentPath = Id.ToString();
            }
            else
            {
                AgentPath = parentAgent.AgentPath + "," + Id;

                //只要3级代理
                var p = AgentPath.Split(',').ToList();
                if (p.Count >= 3)
                {
                    p = p.GetRange(p.Count - 3, 3);
                }

                AgentPath = p.Join(",");
            }

        }
    }
}