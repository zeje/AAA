using System.Collections.Generic;

namespace AAA
{
    /// <summary>
    /// 用户权限
    /// </summary>
    public class CustomerPermission : EntityBase
    {
        /// <summary>
        /// 权限名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 权限代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 权限说明
        /// </summary>
        public string PermissDescription { get; set; }

        /// <summary>
        /// 角色权限集
        /// </summary>
        public virtual ICollection<CustomerRolePermission> UserRolePermissions { get; set; }
    }
}
