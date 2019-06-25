﻿using Util.Domains.Repositories;
using Agents.Agents.Domain.Models;

namespace Agents.Agents.Domain.Repositories {
    /// <summary>
    /// 代理仓储
    /// </summary>
    public interface IAgentRepository : IRepository<Agent> {
    }
}