using Restaurant_Website.Models;

namespace Restaurant_Website.ViewModels
{
    public class MasterCategoryMenuViewModel
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public virtual ICollection<MasterItemMenu> MasterItemMenus { get; set; } = new List<MasterItemMenu>();
        public bool IsActive { get; set; }
    }
}
