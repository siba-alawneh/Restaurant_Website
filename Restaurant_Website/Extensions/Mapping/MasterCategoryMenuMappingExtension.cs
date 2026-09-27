using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterCategoryMenuMappingExtension
    {
       
        public static MasterCategoryMenu ToModel(this MasterCategoryMenuViewModel model)
        {
            
            return new MasterCategoryMenu
            {
               Id = model.Id,
                MenuName = model.MenuName,
               MasterItemMenus= model.MasterItemMenus,
               IsActive = model.IsActive
            };
        }
        public static MasterCategoryMenu ToFullModel(this MasterCategoryMenuFullViewModel model)
        {
            
            return new MasterCategoryMenu
            {
               Id = model.Id,
                MenuName = model.MenuName,
               MasterItemMenus= model.MasterItemMenus,
               IsActive = model.IsActive
            };
        }
        public static MasterCategoryMenuFullViewModel ToFullViewModel(this MasterCategoryMenu model)
        {
            
            return new MasterCategoryMenuFullViewModel
            {
               Id = model.Id,
                MenuName = model.MenuName,
               MasterItemMenus= model.MasterItemMenus,
               IsActive = model.IsActive
            };
        }
        public static MasterCategoryMenuViewModel ToViewModel(this MasterCategoryMenu model)
        {
            
            return new MasterCategoryMenuViewModel
            {
               Id = model.Id,
                MenuName = model.MenuName,
               MasterItemMenus= model.MasterItemMenus,
               IsActive = model.IsActive
            };
        }

        public static List<MasterCategoryMenu> ToModelList(this List<MasterCategoryMenuViewModel> model)
        {
           return model.Select(x => x.ToModel()).ToList();
        }

        public static List<MasterCategoryMenuViewModel> ToViewModelList(this List<MasterCategoryMenu> model)
        {
           return model.Select(x => x.ToViewModel()).ToList();
        }
       
    }
}
