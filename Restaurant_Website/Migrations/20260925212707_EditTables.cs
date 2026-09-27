using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Website.Migrations
{
    /// <inheritdoc />
    public partial class EditTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeFormTo",
                table: "MasterWorkingHours",
                newName: "TimeTo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MasterWorkingHours",
                newName: "TimeForm");

            migrationBuilder.RenameColumn(
                name: "Redirect",
                table: "MasterContactUsInformations",
                newName: "PhoneNumber2");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "MasterContactUsInformations",
                newName: "PhoneNumber1");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "MasterWorkingHours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPupular",
                table: "MasterItemMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MasterContactUsInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email1",
                table: "MasterContactUsInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "MasterContactUsInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "MasterContactUsInformations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "MasterWorkingHours");

            migrationBuilder.DropColumn(
                name: "IsPupular",
                table: "MasterItemMenus");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "MasterContactUsInformations");

            migrationBuilder.DropColumn(
                name: "Email1",
                table: "MasterContactUsInformations");

            migrationBuilder.DropColumn(
                name: "Email2",
                table: "MasterContactUsInformations");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "MasterContactUsInformations");

            migrationBuilder.RenameColumn(
                name: "TimeTo",
                table: "MasterWorkingHours",
                newName: "TimeFormTo");

            migrationBuilder.RenameColumn(
                name: "TimeForm",
                table: "MasterWorkingHours",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber2",
                table: "MasterContactUsInformations",
                newName: "Redirect");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber1",
                table: "MasterContactUsInformations",
                newName: "Icon");
        }
    }
}
