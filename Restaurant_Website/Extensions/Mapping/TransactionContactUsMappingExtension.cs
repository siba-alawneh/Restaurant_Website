using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class TransactionContactUsMappingExtension
    {
        public static TransactionContactUs ToModel(this TransactionContactUsViewModel model)
        {
            return new TransactionContactUs
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message,
                IsActive = model.IsActive
            };
        }
        public static TransactionContactUsViewModel ToViewModel(this TransactionContactUs model)
        {
            return new TransactionContactUsViewModel
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message,
                IsActive = model.IsActive
            };
        }
        public static List<TransactionContactUs> ToModelList(this List<TransactionContactUsViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<TransactionContactUsViewModel> ToViewModelList(this List<TransactionContactUs> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
