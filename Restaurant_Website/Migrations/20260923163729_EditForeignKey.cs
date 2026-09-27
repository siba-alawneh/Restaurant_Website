using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Website.Migrations
{
    /// <inheritdoc />
    public partial class EditForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterItemMenus_MasterCategoryMenus_MasterCategoryMenuId",
                table: "MasterItemMenus");

            migrationBuilder.DropIndex(
                name: "IX_MasterItemMenus_MasterCategoryMenuId",
                table: "MasterItemMenus");

            migrationBuilder.DropColumn(
                name: "WelcomeNoteUrl",
                table: "SystemSettings");

            migrationBuilder.DropColumn(
                name: "SliderUrl",
                table: "MasterSliders");

            migrationBuilder.DropColumn(
                name: "MenuUrl",
                table: "MasterMenus");

            migrationBuilder.DropColumn(
                name: "MasterCategoryMenuId",
                table: "MasterItemMenus");

            migrationBuilder.CreateIndex(
                name: "IX_MasterItemMenus_CategoryId",
                table: "MasterItemMenus",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterItemMenus_MasterCategoryMenus_CategoryId",
                table: "MasterItemMenus",
                column: "CategoryId",
                principalTable: "MasterCategoryMenus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterItemMenus_MasterCategoryMenus_CategoryId",
                table: "MasterItemMenus");

            migrationBuilder.DropIndex(
                name: "IX_MasterItemMenus_CategoryId",
                table: "MasterItemMenus");

            migrationBuilder.AddColumn<string>(
                name: "WelcomeNoteUrl",
                table: "SystemSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SliderUrl",
                table: "MasterSliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuUrl",
                table: "MasterMenus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MasterCategoryMenuId",
                table: "MasterItemMenus",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterItemMenus_MasterCategoryMenuId",
                table: "MasterItemMenus",
                column: "MasterCategoryMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterItemMenus_MasterCategoryMenus_MasterCategoryMenuId",
                table: "MasterItemMenus",
                column: "MasterCategoryMenuId",
                principalTable: "MasterCategoryMenus",
                principalColumn: "Id");
        }
    }
}
