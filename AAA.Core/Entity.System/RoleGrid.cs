using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class RoleGrid : RolePermission
    {
        public RoleGrid()
        {
        }
        /// <summary>
        /// 表格字段
        /// </summary>
        [ForeignKey("PermissionId")]
        public new Grid Permission { get; set; }
    }
}
