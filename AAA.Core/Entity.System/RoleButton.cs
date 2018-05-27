using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class RoleButton : RolePermission
    {
        public RoleButton()
        {
        }
        /// <summary>
        /// 按钮
        /// </summary>
        [ForeignKey("PermissionId")]
        public new Button Permission { get; set; }
    }
}
