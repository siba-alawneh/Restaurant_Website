using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class TransactionBookTableMappingExtension
    {
        public static TransactionBookTable ToModel(this TransactionBookTableViewModel model)
        {
            return new TransactionBookTable
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                MobileNumber = model.MobileNumber,
                Date = model.Date,
                IsActive = model.IsActive
            };
        }
        public static TransactionBookTable ToFullModel(this TransactionBookTableFullViewModel model)
        {
            return new TransactionBookTable
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                MobileNumber = model.MobileNumber,
                Date = model.Date,
                IsActive = model.IsActive
            };
        }
        public static TransactionBookTableViewModel ToViewModel(this TransactionBookTable model)
        {
            return new TransactionBookTableViewModel
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                MobileNumber = model.MobileNumber,
                Date = model.Date,
                IsActive = model.IsActive
            };
        }
        public static TransactionBookTableFullViewModel ToFullViewModel(this TransactionBookTable model)
        {
            return new TransactionBookTableFullViewModel
            {
                Id = model.Id,
                FullName = model.FullName,
                Email = model.Email,
                MobileNumber = model.MobileNumber,
                Date = model.Date,
                IsActive = model.IsActive
            };
        }
        public static List<TransactionBookTable> ToModelList(this List<TransactionBookTableViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<TransactionBookTableViewModel> ToViewModelList(this List<TransactionBookTable> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
