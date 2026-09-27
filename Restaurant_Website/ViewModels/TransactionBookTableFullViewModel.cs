namespace Restaurant_Website.ViewModels
{
    public class TransactionBookTableFullViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string MobileNumber { get; set; } = null!;

        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public List<TransactionBookTableViewModel> List { get; set; }
    }
}
