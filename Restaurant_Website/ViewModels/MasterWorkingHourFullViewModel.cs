namespace Restaurant_Website.ViewModels
{
    public class MasterWorkingHourFullViewModel
    {
        public int Id { get; set; }
        public string Day { get; set; } = null!;
        public string TimeForm { get; set; } = null!;
        public string TimeTo { get; set; } = null!;
        public bool IsActive { get; set; }
        public List<MasterWorkingHourViewModel> List { get; set; }=null!;
    }
}
