using System;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Repositories;
using Agents.Agents.Domain.Services.Abstractions;
using Agents.Agents.Domain.Services.Requests;
using Agents.Finances.Domain.Services.Abstractions;
using Agents.ResultExtensions;
using Agents.Urls;
using Agents.WebClients;
using Util;
using Util.Domains.Services;
using Util.Helpers;
using Util.Webs.Commons;

namespace Agents.Agents.Domain.Services.Implements {
    /// <summary>
    /// 用户管理器
    /// </summary>
    public class UserManager : DomainServiceBase, IUserManager {
        /// <summary>
        /// 初始化用户管理器
        /// </summary>
        public UserManager() {
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        public async Task<Guid> CraeteUser(CreateUserRequest request) {
            var result = await WebClientHelper.PostAsync<Result>($"{UrlProvider.UserServiceUrl}/api/user", request);
            result.ErrorValidate();
            string id = result.Data;
            return id.ToGuid();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public async Task DeleteUser(string ids) {
            //var result = await WebClientHelper.PostAsync<Result>($"{UrlProvider.UserServiceUrl}/api/user/delete", $"'{ids}'");
            var result = await WebClientHelper.PostAsync<Result>($"{UrlProvider.UserServiceUrl}/api/user/delete",  ids );
            result.ErrorValidate();
        }
    }
}