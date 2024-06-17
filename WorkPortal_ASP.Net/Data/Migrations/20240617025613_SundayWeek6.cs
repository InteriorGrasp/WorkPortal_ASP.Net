using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkPortal_ASP.Net.Data.Migrations
{
    /// <inheritdoc />
    public partial class SundayWeek6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLogin_Employees_EmployeeId",
                table: "EmployeeLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLogin",
                table: "EmployeeLogin");

            migrationBuilder.RenameTable(
                name: "EmployeeLogin",
                newName: "EmployeeLogins");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeLogin_EmployeeId",
                table: "EmployeeLogins",
                newName: "IX_EmployeeLogins_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLogins_Employees_EmployeeId",
                table: "EmployeeLogins",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLogins_Employees_EmployeeId",
                table: "EmployeeLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLogins",
                table: "EmployeeLogins");

            migrationBuilder.RenameTable(
                name: "EmployeeLogins",
                newName: "EmployeeLogin");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeLogins_EmployeeId",
                table: "EmployeeLogin",
                newName: "IX_EmployeeLogin_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLogin",
                table: "EmployeeLogin",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLogin_Employees_EmployeeId",
                table: "EmployeeLogin",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
