using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterSliderMappingExtension
    {
        public static MasterSlider ToModel(this MasterSliderViewModel model)
        {
            return new MasterSlider
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                //SliderUrl = model.SliderUrl,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterSlider ToFullModel(this MasterSliderFullViewModel model)
        {
            return new MasterSlider
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                //SliderUrl = model.SliderUrl,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterSliderViewModel ToViewModel(this MasterSlider model)
        {
            return new MasterSliderViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                //SliderUrl = model.SliderUrl,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static MasterSliderFullViewModel ToFullViewModel(this MasterSlider model)
        {
            return new MasterSliderFullViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Breif = model.Breif,
                Desc = model.Desc,
                //SliderUrl = model.SliderUrl,
                ImageUrl = model.ImageUrl,
                IsActive = model.IsActive
            };
        }
        public static List<MasterSlider> ToModelList(this List<MasterSliderViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterSliderViewModel> ToViewModelList(this List<MasterSlider> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();

        }
    }
}
