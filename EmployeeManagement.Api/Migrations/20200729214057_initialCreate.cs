using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "HR" },
                    { 2, "SOFTWARE" },
                    { 3, "BUSINESS" },
                    { 4, "OPERATIONS" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DOB", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "Passport" },
                values: new object[,]
                {
                    { 1, new DateTime(1950, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "john@gmail.com", "Ude", 0, "John", "Images/team1.jpg" },
                    { 2, new DateTime(1950, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "john@gmail.com", "Ude", 0, "John", "Images/team1.jpg" },
                    { 3, new DateTime(1960, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Jane@gmail.com", "Eze", 1, "Jane", "Images/team3.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
