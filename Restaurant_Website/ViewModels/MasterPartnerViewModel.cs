namespace Restaurant_Website.ViewModels
{
    public class MasterPartnerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? LogoImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }

        public string WebsiteUrl { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
