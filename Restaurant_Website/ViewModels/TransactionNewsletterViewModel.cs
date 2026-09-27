namespace Restaurant_Website.ViewModels
{
    public class TransactionNewsletterViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
