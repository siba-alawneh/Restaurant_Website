namespace Restaurant_Website.ViewModels
{
    public class MasterSliderViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Breif { get; set; } = null!;

        public string Desc { get; set; } = null!;
        //public string SliderUrl { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
        public bool IsActive { get; set; }
    }
}
