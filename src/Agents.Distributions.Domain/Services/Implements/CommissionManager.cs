
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Distributions.Domain.Enums;
using Agents.Distributions.Domain.Models;
using Agents.Distributions.Domain.Repositories;
using Agents.Distributions.Domain.Services.Abstractions;
using Agents.Sales.Domain.Models;
using Microsoft.Extensions.Configuration;
using Util;
using Util.Domains.Services;

namespace Agents.Distributions.Domain.Services.Implements {
    /// <summary>
    /// 佣金管理器
    /// </summary>
    public class CommissionManager : DomainServiceBase, ICommissionManager {

        /// <summary>
        /// 初始化佣金管理器
        /// </summary>
        public CommissionManager(ICommissionRepository commissionRepository, IConfiguration configuration, IAgentRepository agentRepository) {
            CommissionRepository = commissionRepository;
            Configuration = configuration;
            AgentRepository = agentRepository;
        }

        /// <summary>
        /// 佣金仓储
        /// </summary>
        public ICommissionRepository CommissionRepository { get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// 代理仓储
        /// </summary>
        public IAgentRepository AgentRepository { get; }

        /// <summary>
        /// 添加佣金
        /// </summary>
        public async Task<Commission> CreateCommissionAsync(Commission model) {
            model.Init();
            await CommissionRepository.AddAsync(model);
            return model;
        }

        /// <summary>
        /// 修改佣金
        /// </summary>
        public async Task UpdateCommission(Commission model) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除佣金
        /// </summary>
        public async Task DeleteCommission(string ids) {
            var entitis = await CommissionRepository.FindByIdsAsync(ids);
            await CommissionRepository.RemoveAsync(entitis);
        }

        /// <summary>
        /// 计算佣金
        /// </summary>
        public async Task CalcCommissionAsync(Order order) {
            order.CommissionState = Sales.Domain.Enums.OrderCommissionState.WaitPay;
            await CaclCommissionLevel1(order);
            await CaclCommissionLevel2(order);
            await CaclCommissionLevel3(order);
        }

        /// <summary>
        /// 结算一级佣金
        /// </summary>
        private async Task CaclCommissionLevel1(Order order) {
            if (order.Member.AgentPath == null || order.Member.Agent == null) {
                return;
            }
            await AddCommissionAsync(order, CommissionType.Level1, order.Member.Agent);

        }

        /// <summary>
        /// 结算二级佣金
        /// </summary>
        private async Task CaclCommissionLevel2(Order order) {
            if (order.Member.AgentPath == null || order.Member.Agent == null) {
                return;
            }
            var parentAgent = await AgentRepository.GetParentAgentAsync(order.Member.Agent);
            if (parentAgent == null) {
                return;
            }
            await AddCommissionAsync(order, CommissionType.Level2, parentAgent);
        }

        /// <summary>
        /// 结算三级佣金
        /// </summary>
        private async Task CaclCommissionLevel3(Order order) {
            if (order.Member.AgentPath == null || order.Member.Agent == null) {
                return;
            }
            var parentAgent = await AgentRepository.GetParentAgentAsync(order.Member.Agent);
            var grandparentAgent = await AgentRepository.GetParentAgentAsync(parentAgent);
            if (grandparentAgent == null) {
                return;
            }
            await AddCommissionAsync(order, CommissionType.Level1, grandparentAgent);
        }

        /// <summary>
        /// 添加佣金
        /// </summary>
        private async Task AddCommissionAsync(Order order, CommissionType type, Agent agent) {
            if (agent == null) {
                return;
            }
            decimal commission = 0;
            switch (type) {
                case CommissionType.Level1:
                    //commission = ConfigHelper.GetConfigString("CommissionLevel1").ToDecimal();
                    commission = 15;
                    break;
                case CommissionType.Level2:
                    //commission = ConfigHelper.GetConfigString("CommissionLevel2").ToDecimal();
                    commission = 10;
                    break;
                case CommissionType.Level3:
                    //commission = ConfigHelper.GetConfigString("CommissionLevel3").ToDecimal();
                    commission = 5;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            var model = new Commission();
            model.Init();
            model.Money = order.Money * commission/100;
            model.Type = type;
            model.State = CommissionState.UnPayed;
            model.AgentId = agent.Id;
            model.OrderId = order.Id;
            await CommissionRepository.AddAsync(model);
        }
    }
}