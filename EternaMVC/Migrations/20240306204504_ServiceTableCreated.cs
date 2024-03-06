using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaMVC.Migrations
{
    /// <inheritdoc />
    public partial class ServiceTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Services",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "description");
        }
    }
}
