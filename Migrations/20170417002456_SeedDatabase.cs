using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make1-ModelA', (SELECT MakeID From Makes WHERE Name='Make1'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make1-ModelB', (SELECT MakeID From Makes WHERE Name='Make1'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make1-ModelC', (SELECT MakeID From Makes WHERE Name='Make1'))");

            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make2-ModelA', (SELECT MakeID From Makes WHERE Name='Make2'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make2-ModelB', (SELECT MakeID From Makes WHERE Name='Make2'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make2-ModelC', (SELECT MakeID From Makes WHERE Name='Make2'))");
            

            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make3-ModelA', (SELECT MakeID From Makes WHERE Name='Make3'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make3-ModelB', (SELECT MakeID From Makes WHERE Name='Make3'))");
            migrationBuilder.Sql("INSERT INTO Model (Name, MakeID) VALUES ('Make3-ModelC', (SELECT MakeID From Makes WHERE Name='Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE From Makes WHERE Name IN ('Make1', 'Make2', 'Make3')");
        }
    }
}
