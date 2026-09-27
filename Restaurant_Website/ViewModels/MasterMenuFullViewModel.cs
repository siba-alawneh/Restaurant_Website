namespace Restaurant_Website.ViewModels
{
    public class MasterMenuFullViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string MenuUrl { get; set; } = null!;
        public bool IsActive { get; set; }
        public List<MasterMenuViewModel> List { get; set; }
    }
}
