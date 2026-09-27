namespace Restaurant_Website.ViewModels
{
    public class MasterMenuViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string MenuUrl { get; set; } = null!;
        public bool IsActive { get; set; }


    }
}
