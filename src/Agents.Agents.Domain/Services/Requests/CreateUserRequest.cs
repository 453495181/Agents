using System.ComponentModel.DataAnnotations;
using Util.Applications.Dtos;

namespace Agents.Agents.Domain.Services.Requests {
    /// <summary>
    /// 创建用户请求参数
    /// </summary>
    public class CreateUserRequest : RequestBase {

        /// <summary>
        /// 构造函数
        /// </summary>
        public CreateUserRequest() {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="email">邮箱</param>
        /// <param name="phoneNumber">手机号</param>
        /// <param name="password">密码</param>
        public CreateUserRequest(string userName, string email, string phoneNumber, string password) {
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(256)]
        [Display(Name = "用户名")]
        public string UserName { get; set; }
        /// <summary>
        /// 安全邮箱
        /// </summary>
        [StringLength(256)]
        [EmailAddress]
        [Display(Name = "邮箱")]
        public string Email { get; set; }
        /// <summary>
        /// 安全手机
        /// </summary>
        [StringLength(64)]
        [Phone]
        [Display(Name = "手机号")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [StringLength(256)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}
