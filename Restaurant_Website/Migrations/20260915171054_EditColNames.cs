using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant_Website.Migrations
{
    /// <inheritdoc />
    public partial class EditColNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionNewsletterEmail",
                table: "TransactionNewsletters",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TransactionContactUsSubject",
                table: "TransactionContactUs",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "TransactionContactUsMessage",
                table: "TransactionContactUs",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "TransactionContactUsFullName",
                table: "TransactionContactUs",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "TransactionContactUsEmail",
                table: "TransactionContactUs",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TransactionBookTableMobileNumber",
                table: "TransactionBookTables",
                newName: "MobileNumber");

            migrationBuilder.RenameColumn(
                name: "TransactionBookTableFullName",
                table: "TransactionBookTables",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "TransactionBookTableEmail",
                table: "TransactionBookTables",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "TransactionBookTableDate",
                table: "TransactionBookTables",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteUrl",
                table: "SystemSettings",
                newName: "WelcomeNoteUrl");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteTitle",
                table: "SystemSettings",
                newName: "WelcomeNoteTitle");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteImageUrl4",
                table: "SystemSettings",
                newName: "WelcomeNoteImageUrl4");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteImageUrl3",
                table: "SystemSettings",
                newName: "WelcomeNoteImageUrl3");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteImageUrl2",
                table: "SystemSettings",
                newName: "WelcomeNoteImageUrl2");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteImageUrl",
                table: "SystemSettings",
                newName: "WelcomeNoteImageUrl");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteDesc",
                table: "SystemSettings",
                newName: "WelcomeNoteDesc");

            migrationBuilder.RenameColumn(
                name: "SystemSettingWelcomeNoteBreif",
                table: "SystemSettings",
                newName: "WelcomeNoteBreif");

            migrationBuilder.RenameColumn(
                name: "SystemSettingMapLocation",
                table: "SystemSettings",
                newName: "MapLocation");

            migrationBuilder.RenameColumn(
                name: "SystemSettingLogoImageUrl2",
                table: "SystemSettings",
                newName: "LogoImageUrl2");

            migrationBuilder.RenameColumn(
                name: "SystemSettingLogoImageUrl",
                table: "SystemSettings",
                newName: "LogoImageUrl");

            migrationBuilder.RenameColumn(
                name: "SystemSettingCopyright",
                table: "SystemSettings",
                newName: "Copyright");

            migrationBuilder.RenameColumn(
                name: "MasterWorkingHourTimeFormTo",
                table: "MasterWorkingHours",
                newName: "TimeFormTo");

            migrationBuilder.RenameColumn(
                name: "MasterWorkingHourName",
                table: "MasterWorkingHours",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MasterSocialMediaUrl",
                table: "MasterSocialMedia",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "MasterSocialMediaIcon",
                table: "MasterSocialMedia",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "MasterSliderUrl",
                table: "MasterSliders",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MasterSliderTitle",
                table: "MasterSliders",
                newName: "SliderUrl");

            migrationBuilder.RenameColumn(
                name: "MasterSliderImageUrl",
                table: "MasterSliders",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "MasterSliderDesc",
                table: "MasterSliders",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterSliderBreif",
                table: "MasterSliders",
                newName: "Breif");

            migrationBuilder.RenameColumn(
                name: "MasterServiceTitle",
                table: "MasterServices",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MasterServiceIcon",
                table: "MasterServices",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "MasterServiceDesc",
                table: "MasterServices",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterPartnerWebsiteUrl",
                table: "MasterPartners",
                newName: "WebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "MasterPartnerName",
                table: "MasterPartners",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MasterPartnerLogoImageUrl",
                table: "MasterPartners",
                newName: "LogoImageUrl");

            migrationBuilder.RenameColumn(
                name: "MasterOfferTitle",
                table: "MasterOffers",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MasterOfferImageUrl",
                table: "MasterOffers",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "MasterOfferDesc",
                table: "MasterOffers",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterOfferBreif",
                table: "MasterOffers",
                newName: "Breif");

            migrationBuilder.RenameColumn(
                name: "MasterMenuUrl",
                table: "MasterMenus",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MasterMenuName",
                table: "MasterMenus",
                newName: "MenuUrl");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuTitle",
                table: "MasterItemMenus",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuPrice",
                table: "MasterItemMenus",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuImageUrl",
                table: "MasterItemMenus",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuDesc",
                table: "MasterItemMenus",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuDate",
                table: "MasterItemMenus",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "MasterItemMenuBreif",
                table: "MasterItemMenus",
                newName: "Breif");

            migrationBuilder.RenameColumn(
                name: "MasterContactUsInformationRedirect",
                table: "MasterContactUsInformations",
                newName: "Redirect");

            migrationBuilder.RenameColumn(
                name: "MasterContactUsInformationIcon",
                table: "MasterContactUsInformations",
                newName: "Icon");

            migrationBuilder.RenameColumn(
                name: "MasterContactUsInformationDesc",
                table: "MasterContactUsInformations",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterCategoryMenuName",
                table: "MasterCategoryMenus",
                newName: "MenuName");

            migrationBuilder.RenameColumn(
                name: "MasterAboutTitle",
                table: "MasterAbouts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MasterAboutImageUrl",
                table: "MasterAbouts",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "MasterAboutDesc",
                table: "MasterAbouts",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "MasterAboutBrief",
                table: "MasterAbouts",
                newName: "Brief");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "MasterItemMenus",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "MasterItemMenus");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TransactionNewsletters",
                newName: "TransactionNewsletterEmail");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "TransactionContactUs",
                newName: "TransactionContactUsSubject");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "TransactionContactUs",
                newName: "TransactionContactUsMessage");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "TransactionContactUs",
                newName: "TransactionContactUsFullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TransactionContactUs",
                newName: "TransactionContactUsEmail");

            migrationBuilder.RenameColumn(
                name: "MobileNumber",
                table: "TransactionBookTables",
                newName: "TransactionBookTableMobileNumber");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "TransactionBookTables",
                newName: "TransactionBookTableFullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TransactionBookTables",
                newName: "TransactionBookTableEmail");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "TransactionBookTables",
                newName: "TransactionBookTableDate");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteUrl",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteUrl");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteTitle",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteTitle");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteImageUrl4",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteImageUrl4");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteImageUrl3",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteImageUrl3");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteImageUrl2",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteImageUrl2");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteImageUrl",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteImageUrl");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteDesc",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteDesc");

            migrationBuilder.RenameColumn(
                name: "WelcomeNoteBreif",
                table: "SystemSettings",
                newName: "SystemSettingWelcomeNoteBreif");

            migrationBuilder.RenameColumn(
                name: "MapLocation",
                table: "SystemSettings",
                newName: "SystemSettingMapLocation");

            migrationBuilder.RenameColumn(
                name: "LogoImageUrl2",
                table: "SystemSettings",
                newName: "SystemSettingLogoImageUrl2");

            migrationBuilder.RenameColumn(
                name: "LogoImageUrl",
                table: "SystemSettings",
                newName: "SystemSettingLogoImageUrl");

            migrationBuilder.RenameColumn(
                name: "Copyright",
                table: "SystemSettings",
                newName: "SystemSettingCopyright");

            migrationBuilder.RenameColumn(
                name: "TimeFormTo",
                table: "MasterWorkingHours",
                newName: "MasterWorkingHourTimeFormTo");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MasterWorkingHours",
                newName: "MasterWorkingHourName");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "MasterSocialMedia",
                newName: "MasterSocialMediaUrl");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "MasterSocialMedia",
                newName: "MasterSocialMediaIcon");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MasterSliders",
                newName: "MasterSliderUrl");

            migrationBuilder.RenameColumn(
                name: "SliderUrl",
                table: "MasterSliders",
                newName: "MasterSliderTitle");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "MasterSliders",
                newName: "MasterSliderImageUrl");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterSliders",
                newName: "MasterSliderDesc");

            migrationBuilder.RenameColumn(
                name: "Breif",
                table: "MasterSliders",
                newName: "MasterSliderBreif");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MasterServices",
                newName: "MasterServiceTitle");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "MasterServices",
                newName: "MasterServiceIcon");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterServices",
                newName: "MasterServiceDesc");

            migrationBuilder.RenameColumn(
                name: "WebsiteUrl",
                table: "MasterPartners",
                newName: "MasterPartnerWebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MasterPartners",
                newName: "MasterPartnerName");

            migrationBuilder.RenameColumn(
                name: "LogoImageUrl",
                table: "MasterPartners",
                newName: "MasterPartnerLogoImageUrl");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MasterOffers",
                newName: "MasterOfferTitle");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "MasterOffers",
                newName: "MasterOfferImageUrl");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterOffers",
                newName: "MasterOfferDesc");

            migrationBuilder.RenameColumn(
                name: "Breif",
                table: "MasterOffers",
                newName: "MasterOfferBreif");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MasterMenus",
                newName: "MasterMenuUrl");

            migrationBuilder.RenameColumn(
                name: "MenuUrl",
                table: "MasterMenus",
                newName: "MasterMenuName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MasterItemMenus",
                newName: "MasterItemMenuTitle");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "MasterItemMenus",
                newName: "MasterItemMenuPrice");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "MasterItemMenus",
                newName: "MasterItemMenuImageUrl");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterItemMenus",
                newName: "MasterItemMenuDesc");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "MasterItemMenus",
                newName: "MasterItemMenuDate");

            migrationBuilder.RenameColumn(
                name: "Breif",
                table: "MasterItemMenus",
                newName: "MasterItemMenuBreif");

            migrationBuilder.RenameColumn(
                name: "Redirect",
                table: "MasterContactUsInformations",
                newName: "MasterContactUsInformationRedirect");

            migrationBuilder.RenameColumn(
                name: "Icon",
                table: "MasterContactUsInformations",
                newName: "MasterContactUsInformationIcon");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterContactUsInformations",
                newName: "MasterContactUsInformationDesc");

            migrationBuilder.RenameColumn(
                name: "MenuName",
                table: "MasterCategoryMenus",
                newName: "MasterCategoryMenuName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "MasterAbouts",
                newName: "MasterAboutTitle");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "MasterAbouts",
                newName: "MasterAboutImageUrl");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "MasterAbouts",
                newName: "MasterAboutDesc");

            migrationBuilder.RenameColumn(
                name: "Brief",
                table: "MasterAbouts",
                newName: "MasterAboutBrief");
        }
    }
}
