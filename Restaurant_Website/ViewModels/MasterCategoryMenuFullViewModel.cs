using Restaurant_Website.Models;

namespace Restaurant_Website.ViewModels
{
    public class MasterCategoryMenuFullViewModel
    {
        public int Id { get; set; }
        public string MenuName { get; set; } = null!;
        public virtual ICollection<MasterItemMenu> MasterItemMenus { get; set; } = new List<MasterItemMenu>();
        public List<MasterCategoryMenuViewModel> List {  get; set; }
        public bool IsActive { get; set; }
    }
}
