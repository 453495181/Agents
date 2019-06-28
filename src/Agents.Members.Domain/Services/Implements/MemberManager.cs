
using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Members.Domain.Models;
using Agents.Members.Domain.Repositories;
using Agents.Members.Domain.Services.Abstractions;
using Util;
using Util.Domains.Services;

namespace Agents.Members.Domain.Services.Implements {
    /// <summary>
    /// 会员管理器
    /// </summary>
    public class MemberManager : DomainServiceBase, IMemberManager {

        /// <summary>
        /// 初始化会员管理器
        /// </summary>
        public MemberManager(IMemberRepository memberRepository, IAgentRepository agentRepository, IDownloadLogRepository downloadLogRepository) {
            MemberRepository = memberRepository;
            AgentRepository = agentRepository;
            DownloadLogRepository = downloadLogRepository;
        }

        /// <summary>
        /// 会员仓储
        /// </summary>
        public IMemberRepository MemberRepository { get; set; }

        /// <summary>
        /// 下载记录管理器
        /// </summary>
        public IDownloadLogRepository DownloadLogRepository { get; }

        /// <summary>
        /// 代理仓储
        /// </summary>
        public IAgentRepository AgentRepository { get; }

        /// <summary>
        /// 添加会员
        /// </summary>
        public async Task<Member> CreateMemberAsync(Member model) {
            await InitMember(model);
            await MemberRepository.AddAsync(model);
            return model;
        }

        /// <summary>
        /// 初始化会员
        /// </summary>
        private async Task InitMember(Member model) {
            model.Init();
            await SetDownloadLog(model);
            await InitMemberAgent(model);
        }

        /// <summary>
        /// 匹配下载记录 设置推荐人
        /// </summary>
        private async Task SetDownloadLog(Member model) {
            if (model.AgentId.HasValue || string.IsNullOrWhiteSpace(model.IPAddress)) {
                return;
            }
            DownloadLog downloadLog = await DownloadLogRepository.GetDownloadLogByIp(model.IPAddress);
            if (downloadLog == null) {
                return;
            }
            model.FirstTime = downloadLog.CreationTime.HasValue ? downloadLog.CreationTime.SafeValue() : model.FirstTime;
            model.AgentId = downloadLog.AgentId;
        }

        /// <summary>
        /// 设置推荐人
        /// </summary>
        private async Task InitMemberAgent(Member model) {
            if (!model.AgentId.HasValue) {
                return;
            }
            var agent = await AgentRepository.FindAsync(model.AgentId.SafeValue());
            model.SetAgent(agent);
        }

        /// <summary>
        /// 修改会员
        /// </summary>
        public async Task UpdateMember(Member model) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除会员
        /// </summary>
        public async Task DeleteMember(string ids) {
            var entitis = await MemberRepository.FindByIdsAsync(ids);
            await MemberRepository.RemoveAsync(entitis);
        }

    }
}