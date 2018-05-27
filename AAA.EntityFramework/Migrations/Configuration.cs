using System.Data.Entity.Migrations;
using Abp.Timing;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AAA.Migrations
{
    public class ConfigurationForTest
    {
        public static void Init()
        {
            using (EntityFramework.AAADbContext context = new EntityFramework.AAADbContext())
            {
                Configuration.Init(context);
            }
        }
    }
    /// <summary>
    /// internal sealed class Configuration
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<AAA.EntityFramework.AAADbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AAA";
        }

        protected override void Seed(AAA.EntityFramework.AAADbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            Init(context);
        }

        public static void Init(AAA.EntityFramework.AAADbContext context)
        {
            var userAdministratorId = new Guid("00000000-0000-0000-0000-000000000001");
            #region 用户
            var userAdministrator = new User()
            {
                Id = userAdministratorId,
                UserAccount = "administrator",
                PassWord = Zeje.Utils.Encrypt_.SHA256("AAA123"),
                UserName = "超级管理员",
                UserStatus = UserStatus.启用,
                LoginIp = "",
                LoginTime = Clock.Now,
                LoginCount = 0,
                LoginFailedTimes = null,
                RegisterIp = "",
                RegisterTime = Clock.Now,
                PasswordSetTime = Clock.Now,
                UserRoles = null,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            var userAdmin = new User()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                UserAccount = "admin",
                PassWord = Zeje.Utils.Encrypt_.SHA256("AAA123"),
                UserName = "管理员",
                UserStatus = UserStatus.启用,
                LoginIp = "",
                LoginTime = Clock.Now,
                LoginCount = 0,
                LoginFailedTimes = null,
                RegisterIp = "",
                RegisterTime = Clock.Now,
                PasswordSetTime = Clock.Now,
                UserRoles = null,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            var userTest = new User()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000003"),
                UserAccount = "test",
                PassWord = Zeje.Utils.Encrypt_.SHA256("123456"),
                UserName = "测试用户",
                UserStatus = UserStatus.启用,
                LoginIp = "",
                LoginTime = Clock.Now,
                LoginCount = 0,
                LoginFailedTimes = null,
                RegisterIp = "",
                RegisterTime = Clock.Now,
                PasswordSetTime = Clock.Now,
                UserRoles = null,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            context.Users.AddOrUpdate(userAdministrator);
            context.Users.AddOrUpdate(userAdmin);
            context.Users.AddOrUpdate(userTest);
            #endregion
            context.SaveChanges();
            #region 部门
            var department = new HrDepartment()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                ParentId = null,
                Name = "3A集团总部",
                Description = "3A集团是一个虚拟的集团",
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            context.HrDepartments.AddOrUpdate(department);
            #endregion
            context.SaveChanges();
            #region 角色
            var roleAdmin = new Role()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "管理员",
                RoleStatus = RoleStatus.启用,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            context.Roles.AddOrUpdate(roleAdmin);
            var roleCommon = new Role()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000002"),
                Name = "普通用户",
                RoleStatus = RoleStatus.启用,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId,
            };
            context.Roles.AddOrUpdate(roleCommon);
            #endregion
            context.SaveChanges();

            #region 用户角色
            context.UserRoles.AddOrUpdate(p => new { p.UserId, p.RoleId },
               new UserRole()
               {
                   UserId = userAdministrator.Id,
                   RoleId = roleAdmin.Id,
               },
               new UserRole()
               {
                   UserId = userAdmin.Id,
                   RoleId = roleAdmin.Id,
               },
               new UserRole()
               {
                   UserId = userTest.Id,
                   RoleId = roleCommon.Id
               });
            #endregion
            context.SaveChanges();
            #region 页面
            var pagePlatform = new Page()
            {
                Id = new Guid("00000000-0000-0000-0000-000000000001"),
                Name = "平台管理",
                Description = "平台管理",
                ParentId = null,
                Sort = 0,
                PageIconClass = "fa fa-link",
                PageUrl = "",
                PageIsMenu = true,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId
            };
            var pageSystem = new Page()
            {
                Id = new Guid("00000000-0000-0000-0001-000000000001"),
                Name = "系统管理",
                Description = "系统管理",
                ParentId = null,
                Sort = 0,
                PageIconClass = "fa fa-link",
                PageUrl = "",
                PageIsMenu = true,
                CreatorUserId = userAdministratorId,
                LastModifierUserId = userAdministratorId
            };
            var subPage = new Page[] {
                    new Page()
                   {
                       Name = "组织机构管理",
                       Description = "组织机构管理",
                       ParentId = pageSystem.Id,
                       Sort = 0,
                       PageIconClass = "fa fa-link",
                       PageUrl = "",
                       PageIsMenu = true,
                       CreatorUserId = userAdministratorId,
                       LastModifierUserId = userAdministratorId
                   },
                   new Page()
                   {
                       Name = "角色管理",
                       Description = "角色管理",
                       ParentId = pageSystem.Id,
                       Sort = 0,
                       PageIconClass = "fa fa-link",
                       PageUrl = "",
                       PageIsMenu = true,
                       CreatorUserId = userAdministratorId,
                       LastModifierUserId = userAdministratorId
                   },
                   new Page()
                   {
                       Name = "用户管理",
                       Description = "用户管理",
                       ParentId = pageSystem.Id,
                       Sort = 0,
                       PageIconClass = "fa fa-link",
                       PageUrl = "",
                       PageIsMenu = true,
                       CreatorUserId = userAdministratorId,
                       LastModifierUserId = userAdministratorId
                   },
                   new Page()
                   {
                       Name = "功能管理",
                       Description = "功能管理",
                       ParentId = pageSystem.Id,
                       Sort = 0,
                       PageIconClass = "fa fa-link",
                       PageUrl = "",
                       PageIsMenu = true,
                       CreatorUserId = userAdministratorId,
                       LastModifierUserId = userAdministratorId
                   }
                };
            context.Pages.AddOrUpdate(pagePlatform);
            context.Pages.AddOrUpdate(pageSystem);
            context.Pages.AddOrUpdate(p => new { p.Name }, subPage.ToArray());
            #endregion
            context.SaveChanges();
        }
    }
}
