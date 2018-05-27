using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;

namespace AAA.EntityFramework
{
    public class AAADbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AAADbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AAADataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AAADbContext since ABP automatically handles it.
         */
        public AAADbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AAADbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AAADbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permission>()
            .HasOptional(t => t.Parent)
            .WithMany(t => t.Children)
            .HasForeignKey(d => d.ParentId);
        }

        #region 系统权限部分
        /// <summary>
        /// 按钮
        /// </summary>
        public DbSet<Button> Buttons { get; set; }
        /// <summary>
        /// 表格
        /// </summary>
        public DbSet<Grid> Grids { get; set; }
        /// <summary>
        /// 表格字段
        /// </summary>
        public DbSet<GridField> GridFields { get; set; }
        /// <summary>
        /// 页面
        /// </summary>
        public DbSet<Page> Pages { get; set; }
        /// <summary>
        /// 权限
        /// </summary>
        public DbSet<Permission> Permissions { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public DbSet<Role> Roles { get; set; }
        /// <summary>
        /// 角色按钮
        /// </summary>
        public DbSet<RoleButton> RoleButtons { get; set; }
        /// <summary>
        /// 角色表格
        /// </summary>
        public DbSet<RoleGrid> RoleGrids { get; set; }
        /// <summary>
        /// 角色表格字段
        /// </summary>
        public DbSet<RoleGridField> RoleGridFields { get; set; }
        /// <summary>
        /// 角色页面
        /// </summary>
        public DbSet<RolePage> RolePages { get; set; }
        /// <summary>
        /// 角色权限
        /// </summary>
        public DbSet<RolePermission> RolePermissions { get; set; }
        /// <summary>
        /// 用户
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        /// <summary>
        /// 员工
        /// </summary>
        public DbSet<HrStaff> HrStaffs { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public DbSet<HrDepartment> HrDepartments { get; set; }
        /// <summary>
        /// 部门员工
        /// </summary>
        public DbSet<HrDepartmentHrStaff> HrDepartmentHrStaffs { get; set; }
        /// <summary>
        /// 部门角色
        /// </summary>
        public DbSet<HrDepartmentRole> HrDepartmentRoles { get; set; }

        public DbSet<SoftVersion> SoftVersions { get; set; }
    }
}
