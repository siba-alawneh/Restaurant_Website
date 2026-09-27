namespace Restaurant_Website.ViewModels
{
    public class TransactionContactUsViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Subject { get; set; } = null!;

        public string Message { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
