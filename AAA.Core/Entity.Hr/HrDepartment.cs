using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace AAA
{
    /// <summary>
    /// 部门
    /// </summary>
    public class HrDepartment : EntitySysBase
    {
        public HrDepartment()
        {
            Sort = 0;
        }
        /// <summary>
        /// 父部门Id
        /// </summary>
        public Guid? ParentId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 上级部门
        /// </summary>
        public HrDepartment Parent { get; set; }
        /// <summary>
        /// 下级部门
        /// </summary>
        public ICollection<HrDepartment> SubHrDepartments { get; set; }
        /// <summary>
        /// 部门人员
        /// </summary>
        public ICollection<HrDepartmentHrStaff> HrDepartmentHrStaffs { get; set; }
    }
}
