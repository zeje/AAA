using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace AAA
{
    /// <summary>
    /// 角色状态
    /// </summary>
    public enum RoleStatus
    {
        停用 = 0,
        启用 = 1
    }

    /// <summary>
    /// 角色信息
    /// </summary>
    public class Role : EntitySysBase, Abp.Domain.Entities.ISoftDelete
    {
        public Role() : base()
        {
            Description = string.Empty;
        }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Description { get; set; }
        /// <summary>
        /// 角色状态
        /// </summary>
        public RoleStatus RoleStatus { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 删除者
        /// </summary>
        public Guid? DeleterUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public ICollection<UserRole> UserRoles { get; set; }
        /// <summary>
        /// 部门角色
        /// </summary>
        public ICollection<HrDepartmentRole> HrDepartmentRoles { get; set; }
    }
}
