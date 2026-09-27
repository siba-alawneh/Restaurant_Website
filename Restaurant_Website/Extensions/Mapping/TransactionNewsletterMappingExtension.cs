using Restaurant_Website.Models;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Extensions.Mapping
{
    public static class TransactionNewsletterMappingExtension
    {
        public static TransactionNewsletter ToModel(this TransactionNewsletterViewModel model)
        {
            return new TransactionNewsletter
            {
                Id = model.Id,
                Email = model.Email,
                IsActive = model.IsActive
            };
        }
        public static TransactionNewsletterViewModel ToViewModel(this TransactionNewsletter model)
        {
            return new TransactionNewsletterViewModel
            {
                Id = model.Id,
                Email = model.Email,
                IsActive = model.IsActive
            };
        }
        public static List<TransactionNewsletter> ToModelList(this List<TransactionNewsletterViewModel> model)
        {
            return model.Select(model => model.ToModel()).ToList();

        }
        public static List<TransactionNewsletterViewModel> ToViewModelList(this List<TransactionNewsletter> model)
        {
            return model.Select(model => model.ToViewModel()).ToList();
        }
    }
}
