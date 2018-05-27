using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class RolePermission : EntitySysBase
    {
        public RolePermission()
        {
        }
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 权限Id
        /// </summary>
        public Guid PermissionId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        /// <summary>
        /// 按钮
        /// </summary>
        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }
    }
}
