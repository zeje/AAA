using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AAA
{
    public class HrDepartmentRole : EntitySysBase
    {
        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid HrDepartmentId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [ForeignKey("HrDepartmentId")]
        public virtual HrDepartment HrDepartment { set; get; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey("RoleId")]
        public virtual Role Role { set; get; }
    }
}
