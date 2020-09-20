using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName", "Phone", "Email", "Organization" },
                values: new object[] { 1, "Delores", "Del Rio", "555-987-6543", "delores@hotmail.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName", "Phone", "Email", "Organization" },
                values: new object[] { 2, "Efren", "Herrera", "555-456-7890", "efren@aol.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "FirstName", "LastName", "Phone", "Email", "Organization" },
                values: new object[] { 3, "Mary Ellen", "Walton", "555-123-4567", "MaryEllen@yahoo.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
                
    }
}
