using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EternaMVC.Migrations
{
    /// <inheritdoc />
    public partial class AboutTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    List1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    List2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    List3 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
