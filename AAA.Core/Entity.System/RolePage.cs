using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class RolePage : RolePermission
    {
        public RolePage()
        {
        }
        /// <summary>
        /// 页面
        /// </summary>
        [ForeignKey("PermissionId")]
        public new Page Permission { get; set; }
    }
}
