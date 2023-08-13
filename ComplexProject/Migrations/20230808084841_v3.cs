using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplexProject.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Field_Field_Id",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Field",
                table: "Field");

            migrationBuilder.RenameTable(
                name: "Field",
                newName: "Fields");

            migrationBuilder.AddColumn<int>(
                name: "CoffeShop_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Company_Id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fields",
                table: "Fields",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CoffeShops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeShops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplainSuggestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplainSuggestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplainSuggestions_Companies_Company_Id",
                        column: x => x.Company_Id,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GeneralServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyGeneralServices",
                columns: table => new
                {
                    Li_CompanyId = table.Column<int>(type: "int", nullable: false),
                    Li_GeneralServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyGeneralServices", x => new { x.Li_CompanyId, x.Li_GeneralServiceId });
                    table.ForeignKey(
                        name: "FK_CompanyGeneralServices_Companies_Li_CompanyId",
                        column: x => x.Li_CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyGeneralServices_GeneralServices_Li_GeneralServiceId",
                        column: x => x.Li_GeneralServiceId,
                        principalTable: "GeneralServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CoffeShop_Id",
                table: "Employees",
                column: "CoffeShop_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Company_Id",
                table: "Employees",
                column: "Company_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyGeneralServices_Li_GeneralServiceId",
                table: "CompanyGeneralServices",
                column: "Li_GeneralServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ComplainSuggestions_Company_Id",
                table: "ComplainSuggestions",
                column: "Company_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Fields_Field_Id",
                table: "Companies",
                column: "Field_Id",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CoffeShops_CoffeShop_Id",
                table: "Employees",
                column: "CoffeShop_Id",
                principalTable: "CoffeShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_Company_Id",
                table: "Employees",
                column: "Company_Id",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Fields_Field_Id",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CoffeShops_CoffeShop_Id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_Company_Id",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "CoffeShops");

            migrationBuilder.DropTable(
                name: "CompanyGeneralServices");

            migrationBuilder.DropTable(
                name: "ComplainSuggestions");

            migrationBuilder.DropTable(
                name: "GeneralServices");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CoffeShop_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Company_Id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fields",
                table: "Fields");

            migrationBuilder.DropColumn(
                name: "CoffeShop_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Company_Id",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Fields",
                newName: "Field");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Field",
                table: "Field",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Field_Field_Id",
                table: "Companies",
                column: "Field_Id",
                principalTable: "Field",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
