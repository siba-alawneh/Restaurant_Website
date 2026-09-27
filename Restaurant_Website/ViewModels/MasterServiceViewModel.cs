namespace Restaurant_Website.ViewModels
{
    public class MasterServiceViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Desc { get; set; } = null!;

        public string Icon { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
