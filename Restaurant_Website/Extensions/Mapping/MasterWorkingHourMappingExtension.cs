using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class MasterWorkingHourMappingExtension
    {
        public static MasterWorkingHour ToModel(this MasterWorkingHourViewModel model)
        {
            return new MasterWorkingHour
            {
                Id = model.Id,
                Day = model.Day,
                TimeForm = model.TimeForm,
                TimeTo = model.TimeTo,
                IsActive = model.IsActive
            };
        }
        public static MasterWorkingHour ToFullModel(this MasterWorkingHourFullViewModel model)
        {
            return new MasterWorkingHour
            {
                Id = model.Id,
                Day = model.Day,
                TimeForm = model.TimeForm,
                TimeTo = model.TimeTo,
                IsActive = model.IsActive
            };
        }
        public static MasterWorkingHourViewModel ToViewModel(this MasterWorkingHour model)
        {
            return new MasterWorkingHourViewModel
            {
                Id = model.Id,
                Day = model.Day,
                TimeForm = model.TimeForm,
                TimeTo = model.TimeTo,
                IsActive = model.IsActive
            };
        }
        public static MasterWorkingHourFullViewModel ToFullViewModel(this MasterWorkingHour model)
        {
            return new MasterWorkingHourFullViewModel
            {
                Id = model.Id,
                Day = model.Day,
                TimeForm = model.TimeForm,
                TimeTo = model.TimeTo,
                IsActive = model.IsActive
            };
        }
        public static List<MasterWorkingHour> ToModelList(this List<MasterWorkingHourViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterWorkingHourViewModel> ToViewModelList(this List<MasterWorkingHour> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
