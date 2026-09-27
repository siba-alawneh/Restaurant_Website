namespace Restaurant_Website.ViewModels
{
    public class SystemSettingViewModel
    {
        public int Id { get; set; }
        public string? LogoImageUrl { get; set; }

        public string? LogoImageUrl2 { get; set; }

        public string Copyright { get; set; } = null!;

        public string WelcomeNoteTitle { get; set; } = null!;

        public string WelcomeNoteBreif { get; set; } = null!;

        public string WelcomeNoteDesc { get; set; } = null!;

        //public string WelcomeNoteUrl { get; set; } = null!;

        public string? WelcomeNoteImageUrl { get; set; }
        public IFormFile ImageFile1 {  get; set; }

        public string? MapLocation { get; set; }

        public string? WelcomeNoteImageUrl2 { get; set; }
        public IFormFile ImageFile2 { get; set; }


        public string? WelcomeNoteImageUrl3 { get; set; }
        public IFormFile ImageFile3 { get; set; }


        public string? WelcomeNoteImageUrl4 { get; set; }
        public IFormFile ImageFile4 { get; set; }

        public bool IsActive { get; set; }
    }
}
