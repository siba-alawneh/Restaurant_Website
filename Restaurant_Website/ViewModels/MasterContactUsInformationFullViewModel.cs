using System.ComponentModel.DataAnnotations;

namespace Restaurant_Website.ViewModels
{
    public class MasterContactUsInformationFullViewModel
    {
        public int Id { get; set; }
        public string Desc { get; set; } = null!;

        //public string Redirect { get; set; } = null!;

        //public string Icon { get; set; } = null!;
        public string PhoneNumber1 { get; set; } = null!;
        public string PhoneNumber2 { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Address { get; set; } = null!;
        [EmailAddress]
        public string Email1 { get; set; } = null!;
        [EmailAddress]
        public string Email2 { get; set; } = null!;
        public bool IsActive { get; set; }
        public List<MasterContactUsInformationViewModel> List { get; set; } = null!;
    }
}
