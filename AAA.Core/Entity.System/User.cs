using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
namespace AAA
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserStatus
    {
        停用 = 0,
        启用 = 1
    }
    /// <summary>
    /// 账户
    /// </summary>
    public class User : EntitySysBase
    {
        public User()
        {
            LoginCount = 0;
        }
        /// <summary>
        /// 账号
        /// </summary>
        [Required]
        [StringLength(128)]
        public string UserAccount { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [StringLength(128)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(128)]
        public string PassWord { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public UserStatus UserStatus { get; set; }
        /// <summary>
        /// 登录Ip
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string LoginIp { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginTime { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginCount { get; set; }
        /// <summary>
        /// 登陆失败累计
        /// </summary>
        public int? LoginFailedTimes { get; set; }
        /// <summary>
        /// 注册Ip
        /// </summary>
        public string RegisterIp { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 密码设置时间，用于提醒检测密码修改周期
        /// </summary>
        public DateTime PasswordSetTime { get; set; }
        /// <summary>
        /// 所属角色
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
