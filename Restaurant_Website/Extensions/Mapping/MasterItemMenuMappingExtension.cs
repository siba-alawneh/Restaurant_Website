using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterItemMenuMappingExtension
    {
        public static MasterItemMenu ToModel(this MasterItemMenuViewModel model)
        {
            return new MasterItemMenu
            {
                Id=model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Date = model.Date,
                IsPupular = model.IsPupular,
                MasterCategoryMenu = model.MasterCategoryMenu,
                IsActive = model.IsActive
            };
        }
        public static MasterItemMenu ToFullModel(this MasterItemMenuFullViewModel model)
        {
            return new MasterItemMenu
            {
                Id=model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Date = model.Date,
                IsPupular = model.IsPupular,
                MasterCategoryMenu = model.MasterCategoryMenu,
                IsActive = model.IsActive
            };
        }
        public static MasterItemMenuViewModel ToViewModel(this MasterItemMenu model)
        {
            return new MasterItemMenuViewModel
            {
                Id = model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Date = model.Date,
                IsPupular = model.IsPupular,
                MasterCategoryMenu = model.MasterCategoryMenu,
                IsActive = model.IsActive
            };
        }
        public static MasterItemMenuFullViewModel ToFullViewModel(this MasterItemMenu model)
        {
            return new MasterItemMenuFullViewModel
            {
                Id = model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                Date = model.Date,
                IsPupular = model.IsPupular,
                MasterCategoryMenu = model.MasterCategoryMenu,
                IsActive = model.IsActive
            };
        }
        public static List<MasterItemMenu> ToModelList(this List<MasterItemMenuViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterItemMenuViewModel> ToViewModelList(this List<MasterItemMenu> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
