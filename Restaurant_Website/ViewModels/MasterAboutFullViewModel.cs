namespace Restaurant_Website.ViewModels
{
    public class MasterAboutFullViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public string Brief { get; set; } = null!;

        public string Desc { get; set; } = null!;

        public string? ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }

        //public string MasterAboutUrl { get; set; } = null!;
        public List<MasterAboutViewModel> List { get; set; }
        public bool IsActive { get; set; }
    }
}
