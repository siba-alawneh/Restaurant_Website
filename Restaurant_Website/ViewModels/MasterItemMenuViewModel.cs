using Restaurant_Website.Models;

namespace Restaurant_Website.ViewModels
{
    public class MasterItemMenuViewModel
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }

        public string Title { get; set; } = null!;

        public string Breif { get; set; } = null!;

        public string Desc { get; set; } = null!;
        public decimal? Price { get; set; }

        public string? ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
        public DateTime Date { get; set; }
        public bool IsPupular { get; set; } = false;
        public virtual MasterCategoryMenu? MasterCategoryMenu { get; set; }
        public bool IsActive { get; set; }
    }
}
