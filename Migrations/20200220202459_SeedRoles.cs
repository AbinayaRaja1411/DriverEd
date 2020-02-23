using Microsoft.EntityFrameworkCore.Migrations;

namespace DriverEd.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d0d5efd1-44a1-4af7-a3f0-1a4250b830c6", "8d5858f9-8a61-4886-a1fd-420c3a472a94", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "689950e2-ac3e-4f9d-9e6e-7edd2a8dd36c", "be5a1e26-ea6f-4d39-87c6-0b92e9b5e2a6", "Instructor", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff7cb3b6-c620-4605-9ef7-4f35ae065c92", "ecf77492-a722-4331-895a-1b54e74add9b", "Student", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689950e2-ac3e-4f9d-9e6e-7edd2a8dd36c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0d5efd1-44a1-4af7-a3f0-1a4250b830c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff7cb3b6-c620-4605-9ef7-4f35ae065c92");
        }
    }
}
