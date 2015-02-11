using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace Twitter.Migrations
{
    public partial class Tweets : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Tweet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false),
                        Text = c.String(),
                        ApplicationUserId = c.String()
                    })
                .PrimaryKey("PK_Tweet", t => t.Id);
            
            migrationBuilder.AddForeignKey(
                "Tweet",
                "FK_Tweet_AspNetUsers_ApplicationUserId",
                new[] { "ApplicationUserId" },
                "AspNetUsers",
                new[] { "Id" },
                cascadeDelete: false);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Tweet");
        }
    }
}