using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Model;
using System;

namespace AngularBookstore.Migrations
{
    public partial class bookProps : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn("Book", "Price", c => c.Decimal(nullable: false));
            
            migrationBuilder.AddColumn("Book", "PublishDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Book", "Price");
            
            migrationBuilder.DropColumn("Book", "PublishDate");
        }
    }
}