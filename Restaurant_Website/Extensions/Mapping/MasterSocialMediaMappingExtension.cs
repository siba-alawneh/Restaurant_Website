using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterSocialMediaMappingExtension
    {
        public static MasterSocialMedia ToModel(this MasterSocialMediaViewModel model)
        {
            return new MasterSocialMedia
            {
                Id = model.Id,
                Icon = model.Icon,
                Url = model.Url,
                WebsiteName = model.WebsiteName,
                IsActive = model.IsActive
            };
        }
        public static MasterSocialMedia ToFullModel(this MasterSocialMediaFullViewModel model)
        {
            return new MasterSocialMedia
            {
                Id = model.Id,
                Icon = model.Icon,
                Url = model.Url,
                WebsiteName = model.WebsiteName,
                IsActive = model.IsActive
            };
        }
        public static MasterSocialMediaViewModel ToViewModel(this MasterSocialMedia model)
        {
            return new MasterSocialMediaViewModel
            {
                Id = model.Id,
                Icon = model.Icon,
                Url = model.Url,
                WebsiteName = model.WebsiteName,
                IsActive = model.IsActive
            };
        }
        public static MasterSocialMediaFullViewModel ToFullViewModel(this MasterSocialMedia model)
        {
            return new MasterSocialMediaFullViewModel
            {
                Id = model.Id,
                Icon = model.Icon,
                Url = model.Url,
                WebsiteName = model.WebsiteName,
                IsActive = model.IsActive
            };
        }
        public static List<MasterSocialMedia> ToModelList(this List<MasterSocialMediaViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterSocialMediaViewModel> ToViewModelList(this List<MasterSocialMedia> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
