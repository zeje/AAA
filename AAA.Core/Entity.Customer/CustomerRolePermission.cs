using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AAA
{
    /// <summary>
    /// 角色权限
    /// </summary>
    public class CustomerRolePermission : EntityBase
    {
        /// <summary>
        /// 角色标识
        /// </summary>
        public string UserRoleId { get; set; }
        /// <summary>
        /// 权限标识
        /// </summary>
        public string PermissionId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public virtual CustomerRole UserRole { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public virtual CustomerPermission Permission { get; set; }
    }
}
