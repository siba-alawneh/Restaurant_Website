using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Website.Migrations
{
    /// <inheritdoc />
    public partial class EditAboutTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MasterAboutUrl",
                table: "MasterAbouts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MasterAboutUrl",
                table: "MasterAbouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
