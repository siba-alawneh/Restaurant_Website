using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterMenuMappingExtension
    {
        public static MasterMenu ToModel(this MasterMenuViewModel model)
        {
            return new MasterMenu
            {
                Id=model.Id,
                Name=model.Name,
                MenuUrl=model.MenuUrl,
                IsActive=model.IsActive
            };
        }
        public static MasterMenu ToFullModel(this MasterMenuFullViewModel model)
        {
            return new MasterMenu
            {
                Id=model.Id,
                Name=model.Name,
                MenuUrl=model.MenuUrl,
                IsActive=model.IsActive
            };
        }
        public static MasterMenuViewModel ToViewModel(this MasterMenu model)
        {
            return new MasterMenuViewModel
            {
                Id = model.Id,
                Name = model.Name,
                MenuUrl = model.MenuUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterMenuFullViewModel ToFullViewModel(this MasterMenu model)
        {
            return new MasterMenuFullViewModel
            {
                Id = model.Id,
                Name = model.Name,
                MenuUrl = model.MenuUrl,
                IsActive = model.IsActive
            };
        }
        public static List<MasterMenu> ToModelList(this List<MasterMenuViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterMenuViewModel> ToViewModelList(this List<MasterMenu> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
