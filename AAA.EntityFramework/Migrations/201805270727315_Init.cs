namespace AAA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 512),
                        ParentId = c.Guid(),
                        Sort = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Guid(),
                        DeletionTime = c.DateTime(),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        ButtonUrl = c.String(maxLength: 128),
                        ButtonIconClass = c.String(maxLength: 64),
                        GridUrl = c.String(maxLength: 128),
                        GridFieldCode = c.String(),
                        GridFieldName = c.String(),
                        PageIconClass = c.String(maxLength: 128),
                        PageUrl = c.String(maxLength: 128),
                        PageIsMenu = c.Boolean(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.HrDepartmentHrStaffs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HrDepartmentId = c.Guid(nullable: false),
                        HrStaffId = c.Guid(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HrDepartments", t => t.HrDepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.HrStaffs", t => t.HrStaffId, cascadeDelete: true)
                .Index(t => t.HrDepartmentId)
                .Index(t => t.HrStaffId);
            
            CreateTable(
                "dbo.HrDepartments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ParentId = c.Guid(),
                        Name = c.String(nullable: false, maxLength: 64),
                        Description = c.String(nullable: false, maxLength: 512),
                        Sort = c.Int(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HrDepartments", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.HrStaffs",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        Sex = c.Boolean(),
                        Birthday = c.DateTime(),
                        Phone = c.String(nullable: false, maxLength: 11),
                        Email = c.String(nullable: false, maxLength: 128),
                        IDCard = c.String(nullable: false, maxLength: 18),
                        MajorDepartmentId = c.Guid(),
                        MajorDepartmentName = c.String(),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HrDepartmentRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        HrDepartmentId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HrDepartments", t => t.HrDepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.HrDepartmentId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(nullable: false, maxLength: 512),
                        RoleStatus = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleterUserId = c.Guid(),
                        DeletionTime = c.DateTime(),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserAccount = c.String(nullable: false, maxLength: 128),
                        UserName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(nullable: false, maxLength: 128),
                        UserStatus = c.Int(nullable: false),
                        LoginIp = c.String(nullable: false, maxLength: 64),
                        LoginTime = c.DateTime(),
                        LoginCount = c.Int(nullable: false),
                        LoginFailedTimes = c.Int(),
                        RegisterIp = c.String(),
                        RegisterTime = c.DateTime(nullable: false),
                        PasswordSetTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        PermissionId = c.Guid(nullable: false),
                        CreatorUserId = c.Guid(nullable: false),
                        LastModifierUserId = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.SoftVersions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SoftName = c.String(nullable: false, maxLength: 32),
                        Version = c.String(nullable: false, maxLength: 32),
                        Url = c.String(nullable: false, maxLength: 128),
                        Changelog = c.String(),
                        Mandatory = c.Boolean(nullable: false),
                        CreatorUserId = c.Long(nullable: false),
                        LastModifierUserId = c.Long(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolePermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.HrDepartmentRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.HrDepartmentRoles", "HrDepartmentId", "dbo.HrDepartments");
            DropForeignKey("dbo.HrDepartmentHrStaffs", "HrStaffId", "dbo.HrStaffs");
            DropForeignKey("dbo.HrDepartments", "ParentId", "dbo.HrDepartments");
            DropForeignKey("dbo.HrDepartmentHrStaffs", "HrDepartmentId", "dbo.HrDepartments");
            DropForeignKey("dbo.Permissions", "ParentId", "dbo.Permissions");
            DropIndex("dbo.RolePermissions", new[] { "PermissionId" });
            DropIndex("dbo.RolePermissions", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.HrDepartmentRoles", new[] { "RoleId" });
            DropIndex("dbo.HrDepartmentRoles", new[] { "HrDepartmentId" });
            DropIndex("dbo.HrDepartments", new[] { "ParentId" });
            DropIndex("dbo.HrDepartmentHrStaffs", new[] { "HrStaffId" });
            DropIndex("dbo.HrDepartmentHrStaffs", new[] { "HrDepartmentId" });
            DropIndex("dbo.Permissions", new[] { "ParentId" });
            DropTable("dbo.SoftVersions");
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.HrDepartmentRoles");
            DropTable("dbo.HrStaffs");
            DropTable("dbo.HrDepartments");
            DropTable("dbo.HrDepartmentHrStaffs");
            DropTable("dbo.Permissions");
        }
    }
}
