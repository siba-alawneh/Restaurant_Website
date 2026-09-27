using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterPartnerMappingExtension
    {
        public static MasterPartner ToModel(this MasterPartnerViewModel model)
        {
            return new MasterPartner
            {
                Id = model.Id,
                Name = model.Name,
                LogoImageUrl = model.LogoImageUrl,
                WebsiteUrl = model.WebsiteUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterPartner ToFullModel(this MasterPartnerFullViewModel model)
        {
            return new MasterPartner
            {
                Id = model.Id,
                Name = model.Name,
                LogoImageUrl = model.LogoImageUrl,
                WebsiteUrl = model.WebsiteUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterPartnerViewModel ToViewModel(this MasterPartner model)
        {
            return new MasterPartnerViewModel
            {
                Id = model.Id,
                Name = model.Name,
                LogoImageUrl = model.LogoImageUrl,
                WebsiteUrl = model.WebsiteUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterPartnerFullViewModel ToFullViewModel(this MasterPartner model)
        {
            return new MasterPartnerFullViewModel
            {
                Id = model.Id,
                Name = model.Name,
                LogoImageUrl = model.LogoImageUrl,
                WebsiteUrl = model.WebsiteUrl,
                IsActive = model.IsActive
            };
        }
        public static List<MasterPartner> ToModelList(this List<MasterPartnerViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterPartnerViewModel> ToViewModelList(this List<MasterPartner> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
