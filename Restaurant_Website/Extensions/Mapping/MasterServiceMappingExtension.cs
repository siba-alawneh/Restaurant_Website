using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterServiceMappingExtension
    {
        public static MasterService ToModel(this MasterServiceViewModel model)
        {
            return new MasterService
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                Desc = model.Desc,
                IsActive = model.IsActive
            };
        }
        public static MasterService ToFullModel(this MasterServiceFullViewModel model)
        {
            return new MasterService
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                Desc = model.Desc,
                IsActive = model.IsActive
            };
        }
        public static MasterServiceViewModel ToViewModel(this MasterService model)
        {
            return new MasterServiceViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                Desc = model.Desc,
                IsActive = model.IsActive
            };
        }
        public static MasterServiceFullViewModel ToFullViewModel(this MasterService model)
        {
            return new MasterServiceFullViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Icon = model.Icon,
                Desc = model.Desc,
                IsActive = model.IsActive
            };
        }
        public static List<MasterService> ToModelList(this List<MasterServiceViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterServiceViewModel> ToViewModelList(this List<MasterService> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();

        }
    }
}