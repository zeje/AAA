using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA
{
    public class HrStaff : EntitySysBase
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool? Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(11)]
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Email { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(18)]
        public string IDCard { get; set; }
        /// <summary>
        /// 主部门id
        /// </summary>
        public Guid? MajorDepartmentId { get; set; }
        /// <summary>
        /// 主部门名称
        /// </summary>
        public string MajorDepartmentName { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        public ICollection<HrDepartmentHrStaff> HrDepartmentHrStaffs { get; set; }
    }
}
