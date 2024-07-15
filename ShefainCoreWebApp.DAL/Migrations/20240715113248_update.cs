using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShefainCoreWebApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonPerson",
                schema: "dbo");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "BD");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "JK");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "PI");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "RK");

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "BN", "Banani", 0 },
                    { "DK", "Dhaka", 0 },
                    { "GP", "Gazipur", 0 },
                    { "NL", "nillphamari", 0 },
                    { "SDP", "Saidpur", 0 }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shohana", "Howlader" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "BN");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "DK");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "GP");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "LookUps",
                keyColumn: "Code",
                keyValue: "SDP");

            migrationBuilder.CreateTable(
                name: "PersonPerson",
                schema: "dbo",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPerson", x => new { x.ChildrenId, x.ParentsId });
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ChildrenId",
                        column: x => x.ChildrenId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ParentsId",
                        column: x => x.ParentsId,
                        principalSchema: "dbo",
                        principalTable: "Persons",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "BD", "Dhaka", 0 },
                    { "JK", "Saidpur", 0 },
                    { "PI", "Banani", 0 },
                    { "RK", "Gazipur", 0 }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "shohana", "howlader" });

            migrationBuilder.CreateIndex(
                name: "IX_PersonPerson_ParentsId",
                schema: "dbo",
                table: "PersonPerson",
                column: "ParentsId");
        }
    }
}
