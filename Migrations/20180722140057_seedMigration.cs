using Microsoft.EntityFrameworkCore.Migrations;

namespace AnyShop.Migrations
{
    public partial class seedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make3')");

            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelA',(select id from Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelB',(select id from Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelC',(select id from Makes where Name='Make1'))");

            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelA',(select id from Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelB',(select id from Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models(Name,MakeID) values ('Make1-ModelC',(select id from Makes where Name='Make2'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Makes where Name IN ('Make1','Make2','Make3')");
        }
    }
}

