using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ContactList.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "Contacts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(nullable: false),
                    CatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CatName" },
                values: new object[,]
                {
                    { "Fr", "Friend" },
                    { "W", "Work" },
                    { "Fm", "Family" }
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "CategoryId",
                value: "Fr");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "CategoryId",
                value: "W");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "CategoryId",
                value: "Fm");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Categories_CategoryId",
                table: "Contacts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Categories_CategoryId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_CategoryId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contacts");
        }
    }
}