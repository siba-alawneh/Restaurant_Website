namespace Restaurant_Website.ViewModels
{
    public class HomeViewModel
    {
        public MasterAboutViewModel MasterAbout { get; set; }
        public List<MasterCategoryMenuViewModel> MasterCategoryMenu { get; set; }
        public MasterContactUsInformationViewModel MasterContactUsInformation { get; set; }
        public List<MasterItemMenuViewModel> MasterItemMenu { get; set; }
        public List<MasterMenuViewModel> MasterMenu { get; set; }
        public List<MasterOfferViewModel> MasterOffer { get; set; }
        public List<MasterPartnerViewModel> MasterPartner { get; set; }
        public List<MasterServiceViewModel> MasterService { get; set; }
        public List<MasterSliderViewModel> MasterSlider { get; set; }
        public List<MasterSocialMediaViewModel> MasterSocialMedia { get; set; }
        public List<MasterWorkingHourViewModel> MasterWorkingHour { get; set; }
        public SystemSettingViewModel SystemSetting { get; set; }
        public List<TransactionBookTableViewModel> TransactionBookTable { get; set; }
        public List<TransactionContactUsViewModel> TransactionContactUs { get; set; }
        public List<TransactionNewsletterViewModel> TransactionNewsletter { get; set; }

    }
}
