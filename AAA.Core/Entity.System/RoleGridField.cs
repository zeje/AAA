using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class RoleGridField : RolePermission
    {
        public RoleGridField()
        {
        }
        /// <summary>
        /// 表格字段
        /// </summary>
        [ForeignKey("PermissionId")]
        public new GridField Permission { get; set; }
    }
}
