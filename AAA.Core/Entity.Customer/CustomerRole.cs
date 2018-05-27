using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 用户角色
    /// </summary>
    public class CustomerRole : EntityBase
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 角色代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 角色说明
        /// </summary>
        public string RoleDescription { get; set; }
        /// <summary>
        /// 角色权限集
        /// </summary>
        public virtual ICollection<CustomerRolePermission> UserRolePermissions { get; set; }
    }
}
