using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace AAA
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class UserRole : EntitySysBase
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public Role Role { get; set; }
    }
}
