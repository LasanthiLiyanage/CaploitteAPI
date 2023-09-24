using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaploitteAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "EmployeeDetail");

            migrationBuilder.AddColumn<double>(
                name: "SalaryAmount",
                table: "UserLoginDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UserRole",
                table: "UserLoginDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "EmployeeDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeDetail",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "EmployeeDetail",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaryAmount",
                table: "UserLoginDetail");

            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "UserLoginDetail");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "EmployeeDetail");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeDetail");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "EmployeeDetail");

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "EmployeeDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
