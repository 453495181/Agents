using System.Collections.Generic;
using Agents.Menus;
using Microsoft.AspNetCore.Mvc;
using Util.Webs.Controllers;

namespace Agents.Apis.Menus {
    /// <summary>
    /// 菜单控制器
    /// </summary>
    public class MenuController : WebApiControllerBase {
        /// <summary>
        /// 获取应用程序数据
        /// </summary>
        [HttpGet]
        public IActionResult GetAppData() {
            var data = new AppData {
                App = { Name = "Agents", Description = "支付分销系统" },
                User = { Name = "何镇汐", Avatar = "/assets/img/avatar.jpg", Email = "xiadao521@qq.com" },
                Menu = new List<MenuInfo> {
                    GetMainMenu(),
                    GetSystemMenu(),
                    GetAgentMenu()
                }
            };
            return Success(data);
        }

        /// <summary>
        /// 获取主导航菜单
        /// </summary>
        private MenuInfo GetMainMenu() {
            return new MenuInfo {
                Text = "主菜单",
                Group = true,
                HideInBreadcrumb = true,
                Children = {
                    new MenuInfo {
                        Text = "仪表盘",
                        Icon = "anticon anticon-dashboard",
                        Children = {
                            new MenuInfo {
                                Text = "默认页",
                                Icon = "anticon anticon-dashboard",
                                Link = "/dashboard/v1",
                            }
                        }
                    }
                }
            };
        }

        /// <summary>
        /// 获取系统菜单
        /// </summary>
        private MenuInfo GetSystemMenu() {
            return new MenuInfo {
                Text = "系统菜单",
                Group = true,
                Children = {
                    new MenuInfo {
                        Text = "代理管理",
                        Icon = "cloud",
                        Link = "/agents/agent"
                    },
                    new MenuInfo {
                        Text = "会员管理",
                        Icon = "cloud",
                        Link = "/members/member"
                    }
                }
            };
        }

        /// <summary>
        /// 获取代理菜单
        /// </summary>
        private MenuInfo GetAgentMenu() {
            return new MenuInfo {
                Text = "代理菜单",
                Group = true,
                Children = {
                    new MenuInfo {
                        Text = "代理管理",
                        Icon = "cloud",
                        Link = "/agents/subagent"
                    },
                    new MenuInfo {
                        Text = "会员管理",
                        Icon = "cloud",
                        Link = "/members/member/submember"
                    },
                    new MenuInfo {
                        Text = "提现列表",
                        Icon = "cloud",
                        Link = "/agents/out-cash"
                    }
                }
            };
        }
    }
}