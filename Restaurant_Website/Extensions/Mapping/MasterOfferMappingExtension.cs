using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterOfferMappingExtension
    {
        public static MasterOffer ToModel(this MasterOfferViewModel model)
        {
            return new MasterOffer
            {
                Id = model.Id,
                Title= model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterOffer ToFullModel(this MasterOfferFullViewModel model)
        {
            return new MasterOffer
            {
                Id = model.Id,
                Title= model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterOfferViewModel ToViewModel(this MasterOffer model)
        {
            return new MasterOfferViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterOfferFullViewModel ToFullViewModel(this MasterOffer model)
        {
            return new MasterOfferFullViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static List<MasterOffer> ToModelList(this List<MasterOfferViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterOfferViewModel> ToViewModelList(this List<MasterOffer> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
