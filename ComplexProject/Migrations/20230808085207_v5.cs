using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplexProject.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Fields_Field_Id",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyGeneralServices_Companies_Li_CompanyId",
                table: "CompanyGeneralServices");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyGeneralServices_GeneralServices_Li_GeneralServiceId",
                table: "CompanyGeneralServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplainSuggestions_Companies_Company_Id",
                table: "ComplainSuggestions");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CoffeShops_CoffeShop_Id",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_Company_Id",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralServices",
                table: "GeneralServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fields",
                table: "Fields");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComplainSuggestions",
                table: "ComplainSuggestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoffeShops",
                table: "CoffeShops");

            migrationBuilder.RenameTable(
                name: "GeneralServices",
                newName: "GeneralService");

            migrationBuilder.RenameTable(
                name: "Fields",
                newName: "Field");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "ComplainSuggestions",
                newName: "ComplainSuggestion");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "CoffeShops",
                newName: "CoffeShop");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_Company_Id",
                table: "Employee",
                newName: "IX_Employee_Company_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_CoffeShop_Id",
                table: "Employee",
                newName: "IX_Employee_CoffeShop_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ComplainSuggestions_Company_Id",
                table: "ComplainSuggestion",
                newName: "IX_ComplainSuggestion_Company_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_Field_Id",
                table: "Company",
                newName: "IX_Company_Field_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralService",
                table: "GeneralService",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Field",
                table: "Field",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComplainSuggestion",
                table: "ComplainSuggestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoffeShop",
                table: "CoffeShop",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Field_Field_Id",
                table: "Company",
                column: "Field_Id",
                principalTable: "Field",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyGeneralServices_Company_Li_CompanyId",
                table: "CompanyGeneralServices",
                column: "Li_CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyGeneralServices_GeneralService_Li_GeneralServiceId",
                table: "CompanyGeneralServices",
                column: "Li_GeneralServiceId",
                principalTable: "GeneralService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComplainSuggestion_Company_Company_Id",
                table: "ComplainSuggestion",
                column: "Company_Id",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_CoffeShop_CoffeShop_Id",
                table: "Employee",
                column: "CoffeShop_Id",
                principalTable: "CoffeShop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_Company_Id",
                table: "Employee",
                column: "Company_Id",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Field_Field_Id",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyGeneralServices_Company_Li_CompanyId",
                table: "CompanyGeneralServices");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyGeneralServices_GeneralService_Li_GeneralServiceId",
                table: "CompanyGeneralServices");

            migrationBuilder.DropForeignKey(
                name: "FK_ComplainSuggestion_Company_Company_Id",
                table: "ComplainSuggestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_CoffeShop_CoffeShop_Id",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_Company_Id",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralService",
                table: "GeneralService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Field",
                table: "Field");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComplainSuggestion",
                table: "ComplainSuggestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoffeShop",
                table: "CoffeShop");

            migrationBuilder.RenameTable(
                name: "GeneralService",
                newName: "GeneralServices");

            migrationBuilder.RenameTable(
                name: "Field",
                newName: "Fields");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "ComplainSuggestion",
                newName: "ComplainSuggestions");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "CoffeShop",
                newName: "CoffeShops");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_Company_Id",
                table: "Employees",
                newName: "IX_Employees_Company_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_CoffeShop_Id",
                table: "Employees",
                newName: "IX_Employees_CoffeShop_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ComplainSuggestion_Company_Id",
                table: "ComplainSuggestions",
                newName: "IX_ComplainSuggestions_Company_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Company_Field_Id",
                table: "Companies",
                newName: "IX_Companies_Field_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralServices",
                table: "GeneralServices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fields",
                table: "Fields",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComplainSuggestions",
                table: "ComplainSuggestions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoffeShops",
                table: "CoffeShops",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Fields_Field_Id",
                table: "Companies",
                column: "Field_Id",
                principalTable: "Fields",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyGeneralServices_Companies_Li_CompanyId",
                table: "CompanyGeneralServices",
                column: "Li_CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyGeneralServices_GeneralServices_Li_GeneralServiceId",
                table: "CompanyGeneralServices",
                column: "Li_GeneralServiceId",
                principalTable: "GeneralServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComplainSuggestions_Companies_Company_Id",
                table: "ComplainSuggestions",
                column: "Company_Id",
                principalTable: "Companies",
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
    }
}
