namespace Restaurant_Website.ViewModels
{
    public class TransactionBookTableViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string MobileNumber { get; set; } = null!;

        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
    }
}
