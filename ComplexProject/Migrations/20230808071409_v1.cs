using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplexProject.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Field_Id",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Field_Id",
                table: "Companies",
                column: "Field_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Field_Field_Id",
                table: "Companies",
                column: "Field_Id",
                principalTable: "Field",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Field_Field_Id",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Field_Id",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Field_Id",
                table: "Companies");
        }
    }
}
