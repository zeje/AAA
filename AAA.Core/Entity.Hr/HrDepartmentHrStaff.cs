using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AAA
{
    public class HrDepartmentHrStaff : EntitySysBase
    {
        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid HrDepartmentId { get; set; }
        /// <summary>
        /// 员工Id
        /// </summary>
        public Guid HrStaffId { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [ForeignKey("HrDepartmentId")]
        public virtual HrDepartment HrDepartment { set; get; }
        /// <summary>
        /// 用户
        /// </summary>
        [ForeignKey("HrStaffId")]
        public virtual HrStaff HrStaff { set; get; }
    }
}
