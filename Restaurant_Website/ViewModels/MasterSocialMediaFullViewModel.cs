namespace Restaurant_Website.ViewModels
{
    public class MasterSocialMediaFullViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public string WebsiteName { get; set; } = null!;
        public bool IsActive { get; set; }
        public List<MasterSocialMediaViewModel> List { get; set; } = null!;
    }
}
