using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;

namespace Twitter.WebModel.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("AspNetRoles",
                c => new
                    {
                        Id = c.String(),
                        Name = c.String()
                    })
                .PrimaryKey("PK_AspNetRoles", t => t.Id);
            
            migrationBuilder.CreateTable("AspNetRoleClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        RoleId = c.String()
                    })
                .PrimaryKey("PK_AspNetRoleClaims", t => t.Id);
            
            migrationBuilder.CreateTable("AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        UserId = c.String()
                    })
                .PrimaryKey("PK_AspNetUserClaims", t => t.Id);
            
            migrationBuilder.CreateTable("AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ProviderDisplayName = c.String(),
                        UserId = c.String()
                    })
                .PrimaryKey("PK_AspNetUserLogins", t => new { t.LoginProvider, t.ProviderKey });
            
            migrationBuilder.CreateTable("AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(),
                        RoleId = c.String()
                    })
                .PrimaryKey("PK_AspNetUserRoles", t => new { t.UserId, t.RoleId });
            
            migrationBuilder.CreateTable("AspNetUsers",
                c => new
                    {
                        Id = c.String(),
                        AccessFailedCount = c.Int(nullable: false),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        LockoutEnabled = c.Boolean(nullable: false),
                        LockoutEnd = c.DateTimeOffset(),
                        NormalizedUserName = c.String(),
                        PasswordHash = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        SecurityStamp = c.String(),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        UserName = c.String()
                    })
                .PrimaryKey("PK_AspNetUsers", t => t.Id);
            
            migrationBuilder.CreateTable("Tweet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        Text = c.String(),
                        AuthorId = c.String()
                    })
                .PrimaryKey("PK_Tweet", t => t.Id);
            
            migrationBuilder.AddForeignKey(
                "AspNetRoleClaims",
                "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                new[] { "RoleId" },
                "AspNetRoles",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "AspNetUserClaims",
                "FK_AspNetUserClaims_AspNetUsers_UserId",
                new[] { "UserId" },
                "AspNetUsers",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "AspNetUserLogins",
                "FK_AspNetUserLogins_AspNetUsers_UserId",
                new[] { "UserId" },
                "AspNetUsers",
                new[] { "Id" },
                cascadeDelete: false);
            
            migrationBuilder.AddForeignKey(
                "Tweet",
                "FK_Tweet_AspNetUsers_AuthorId",
                new[] { "AuthorId" },
                "AspNetUsers",
                new[] { "Id" },
                cascadeDelete: false);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey("AspNetRoleClaims", "FK_AspNetRoleClaims_AspNetRoles_RoleId");
            
            migrationBuilder.DropForeignKey("AspNetUserClaims", "FK_AspNetUserClaims_AspNetUsers_UserId");
            
            migrationBuilder.DropForeignKey("AspNetUserLogins", "FK_AspNetUserLogins_AspNetUsers_UserId");
            
            migrationBuilder.DropForeignKey("Tweet", "FK_Tweet_AspNetUsers_AuthorId");
            
            migrationBuilder.DropTable("AspNetRoles");
            
            migrationBuilder.DropTable("AspNetRoleClaims");
            
            migrationBuilder.DropTable("AspNetUserClaims");
            
            migrationBuilder.DropTable("AspNetUserLogins");
            
            migrationBuilder.DropTable("AspNetUserRoles");
            
            migrationBuilder.DropTable("AspNetUsers");
            
            migrationBuilder.DropTable("Tweet");
        }
    }
}