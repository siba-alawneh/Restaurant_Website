using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterAboutMappingExtension
    {
        public static MasterAbout ToModel(this MasterAboutViewModel model)
        {
            return new MasterAbout
            {
                Id = model.Id,  
                Title =model.Title,
                Brief =model.Brief,
                Desc =model.Desc,
                ImageUrl =model.ImageUrl,
                //MasterAboutUrl = model.MasterAboutUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterAbout ToFullModel(this MasterAboutFullViewModel model)
        {
            return new MasterAbout
            {
                Id = model.Id,  
                Title =model.Title,
                Brief =model.Brief,
                Desc =model.Desc,
                ImageUrl =model.ImageUrl,
                //MasterAboutUrl = model.MasterAboutUrl,
                IsActive = model.IsActive,
                
            };
        }
        public static MasterAboutViewModel ToViewModel(this MasterAbout model)
        {
            return new MasterAboutViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Brief = model.Brief,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                //MasterAboutUrl = model.MasterAboutUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterAboutViewModel ToFullViewModel(this MasterAbout model)
        {
            return new MasterAboutViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Brief = model.Brief,
                Desc = model.Desc,
                ImageUrl = model.ImageUrl,
                //MasterAboutUrl = model.MasterAboutUrl,
                IsActive = model.IsActive
            };
        }
        public static List<MasterAbout> ToModelList(this List<MasterAboutViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterAboutViewModel> ToViewModelList(this List<MasterAbout> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}