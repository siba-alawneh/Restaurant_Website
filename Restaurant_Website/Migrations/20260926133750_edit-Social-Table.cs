using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Website.Migrations
{
    /// <inheritdoc />
    public partial class editSocialTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WebsiteName",
                table: "MasterSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebsiteName",
                table: "MasterSocialMedia");
        }
    }
}
