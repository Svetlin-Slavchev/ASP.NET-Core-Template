using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleProject.Data.Data.Migrations
{
    public partial class Thirt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TestEFEntityTwo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "TestEFEntityTwo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TestEFEntity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "TestEFEntity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TestEFEntityTwo");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TestEFEntityTwo");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TestEFEntity");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "TestEFEntity");
        }
    }
}
