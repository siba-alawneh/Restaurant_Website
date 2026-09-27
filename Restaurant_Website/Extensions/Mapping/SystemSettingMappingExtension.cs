using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class SystemSettingMappingExtension
    {
        public static SystemSetting ToModel(this SystemSettingViewModel model)
        {
            return new SystemSetting
            {
                Id = model.Id,
                LogoImageUrl=model.LogoImageUrl,
                LogoImageUrl2=model.LogoImageUrl2,
                Copyright=model.Copyright,
                WelcomeNoteTitle=model.WelcomeNoteTitle,
                WelcomeNoteBreif=model.WelcomeNoteBreif,
                WelcomeNoteDesc=model.WelcomeNoteDesc,
                //WelcomeNoteUrl=model.WelcomeNoteUrl,
                WelcomeNoteImageUrl=model.WelcomeNoteImageUrl,
                MapLocation=model.MapLocation,
                WelcomeNoteImageUrl2=model.WelcomeNoteImageUrl2,
                WelcomeNoteImageUrl3=model.WelcomeNoteImageUrl3,
                WelcomeNoteImageUrl4=model.WelcomeNoteImageUrl4,
                IsActive = model.IsActive
            };
        }
        public static SystemSetting ToFullModel(this SystemSettingFullViewModel model)
        {
            return new SystemSetting
            {
                Id = model.Id,
                LogoImageUrl=model.LogoImageUrl,
                LogoImageUrl2=model.LogoImageUrl2,
                Copyright=model.Copyright,
                WelcomeNoteTitle=model.WelcomeNoteTitle,
                WelcomeNoteBreif=model.WelcomeNoteBreif,
                WelcomeNoteDesc=model.WelcomeNoteDesc,
                //WelcomeNoteUrl=model.WelcomeNoteUrl,
                WelcomeNoteImageUrl=model.WelcomeNoteImageUrl,
                MapLocation=model.MapLocation,
                WelcomeNoteImageUrl2=model.WelcomeNoteImageUrl2,
                WelcomeNoteImageUrl3=model.WelcomeNoteImageUrl3,
                WelcomeNoteImageUrl4=model.WelcomeNoteImageUrl4,
                IsActive = model.IsActive
            };
        }
        public static SystemSettingViewModel ToViewModel(this SystemSetting model)
        {
            return new SystemSettingViewModel
            {
                Id = model.Id,
                LogoImageUrl = model.LogoImageUrl,
                LogoImageUrl2 = model.LogoImageUrl2,
                Copyright = model.Copyright,
                WelcomeNoteTitle = model.WelcomeNoteTitle,
                WelcomeNoteBreif = model.WelcomeNoteBreif,
                WelcomeNoteDesc = model.WelcomeNoteDesc,
                //WelcomeNoteUrl = model.WelcomeNoteUrl,
                WelcomeNoteImageUrl = model.WelcomeNoteImageUrl,
                MapLocation = model.MapLocation,
                WelcomeNoteImageUrl2 = model.WelcomeNoteImageUrl2,
                WelcomeNoteImageUrl3 = model.WelcomeNoteImageUrl3,
                WelcomeNoteImageUrl4 = model.WelcomeNoteImageUrl4,
                IsActive = model.IsActive
            };
        }
        public static SystemSettingFullViewModel ToFullViewModel(this SystemSetting model)
        {
            return new SystemSettingFullViewModel
            {
                Id = model.Id,
                LogoImageUrl = model.LogoImageUrl,
                LogoImageUrl2 = model.LogoImageUrl2,
                Copyright = model.Copyright,
                WelcomeNoteTitle = model.WelcomeNoteTitle,
                WelcomeNoteBreif = model.WelcomeNoteBreif,
                WelcomeNoteDesc = model.WelcomeNoteDesc,
                //WelcomeNoteUrl = model.WelcomeNoteUrl,
                WelcomeNoteImageUrl = model.WelcomeNoteImageUrl,
                MapLocation = model.MapLocation,
                WelcomeNoteImageUrl2 = model.WelcomeNoteImageUrl2,
                WelcomeNoteImageUrl3 = model.WelcomeNoteImageUrl3,
                WelcomeNoteImageUrl4 = model.WelcomeNoteImageUrl4,
                IsActive = model.IsActive
            };
        }
        public static List<SystemSetting> ToModelList(this List<SystemSettingViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<SystemSettingViewModel> ToViewModelList(this List<SystemSetting> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
