using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{

    public static class MasterContactUsInformationMappingExtension
    {
        public static MasterContactUsInformation ToModel(this MasterContactUsInformationViewModel model)
        {
            return new MasterContactUsInformation
            {
                Id = model.Id,
                Desc=model.Desc,
                //Redirect=model.Redirect,
                //Icon=model.Icon,
                PhoneNumber1 = model.PhoneNumber1,
                PhoneNumber2 = model.PhoneNumber2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Location = model.Location,
                Address = model.Address, 
                IsActive=model.IsActive
            };
        }
        public static MasterContactUsInformation ToFullModel(this MasterContactUsInformationFullViewModel model)
        {
            return new MasterContactUsInformation
            {
                Id = model.Id,
                Desc = model.Desc,
                //Redirect=model.Redirect,
                //Icon=model.Icon,
                PhoneNumber1 = model.PhoneNumber1,
                PhoneNumber2 = model.PhoneNumber2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Location = model.Location,
                Address = model.Address,
                IsActive = model.IsActive
            };
        }
        public static MasterContactUsInformationViewModel ToViewModel(this MasterContactUsInformation model)
        {
            return new MasterContactUsInformationViewModel
            {
                Id = model.Id,
                Desc = model.Desc,
                //Redirect=model.Redirect,
                //Icon=model.Icon,
                PhoneNumber1 = model.PhoneNumber1,
                PhoneNumber2 = model.PhoneNumber2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Location = model.Location,
                Address = model.Address,
                IsActive = model.IsActive
            };
        }
        public static MasterContactUsInformationFullViewModel ToFullViewModel(this MasterContactUsInformation model)
        {
            return new MasterContactUsInformationFullViewModel
            {
                Id = model.Id,
                Desc = model.Desc,
                //Redirect=model.Redirect,
                //Icon=model.Icon,
                PhoneNumber1 = model.PhoneNumber1,
                PhoneNumber2 = model.PhoneNumber2,
                Email1 = model.Email1,
                Email2 = model.Email2,
                Location = model.Location,
                Address = model.Address,
                IsActive = model.IsActive
            };
        }
        public static List<MasterContactUsInformation> ToModelList(this List<MasterContactUsInformationViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<MasterContactUsInformationViewModel> ToViewModelList(this List<MasterContactUsInformation> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
