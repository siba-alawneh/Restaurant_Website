using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Website.Extensions.Mapping;
using Restaurant_Website.Models;
using Restaurant_Website.Repositories;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<MasterAbout> MasterAboutRepository;
        IRepository<MasterCategoryMenu> MasterCategoryMenuRepository;
        IRepository<MasterContactUsInformation> MasterContactUsInformationRepository;
        IRepository<MasterItemMenu> MasterItemMenuRepository;
        IRepository<MasterMenu> MasterMenuRepository;
        IRepository<MasterOffer> MasterOfferRepository;
        IRepository<MasterPartner> MasterPartnerRepository;
        IRepository<MasterService> MasterServiceRepository;
        IRepository<MasterSlider> MasterSliderRepository;
        IRepository<MasterSocialMedia> MasterSocialMediaRepository;
        IRepository<MasterWorkingHour> MasterWorkingHourRepository;
        IRepository<SystemSetting> SystemSettingRepository;
        IRepository<TransactionBookTable> TransactionBookTableRepository;
        IRepository<TransactionContactUs> TransactionContactUsRepository;
        IRepository<TransactionNewsletter> TransactionNewsletterRepository;
        public HomeController(ILogger<HomeController> logger, IRepository<MasterAbout> masterAboutRepository, IRepository<MasterCategoryMenu> masterCategoryMenuRepository, IRepository<MasterContactUsInformation> masterContactUsInformationRepository, IRepository<MasterItemMenu> masterItemMenuRepository, IRepository<MasterMenu> masterMenuRepository, IRepository<MasterOffer> masterOfferRepository, IRepository<MasterPartner> masterPartnerRepository, IRepository<MasterService> masterServiceRepository, IRepository<MasterSlider> masterSliderRepository, IRepository<MasterSocialMedia> masterSocialMediaRepository, IRepository<MasterWorkingHour> masterWorkingHourRepository, IRepository<SystemSetting> systemSettingRepository, IRepository<TransactionBookTable> transactionBookTableRepository, IRepository<TransactionContactUs> transactionContactUsRepository, IRepository<TransactionNewsletter> transactionNewsletterRepository)
        {
            _logger = logger;
            MasterAboutRepository = masterAboutRepository;
            MasterCategoryMenuRepository = masterCategoryMenuRepository;
            MasterContactUsInformationRepository = masterContactUsInformationRepository;
            MasterItemMenuRepository = masterItemMenuRepository;
            MasterMenuRepository = masterMenuRepository;
            MasterOfferRepository = masterOfferRepository;
            MasterPartnerRepository = masterPartnerRepository;
            MasterServiceRepository = masterServiceRepository;
            MasterSliderRepository = masterSliderRepository;
            MasterSocialMediaRepository = masterSocialMediaRepository;
            MasterWorkingHourRepository = masterWorkingHourRepository;
            SystemSettingRepository = systemSettingRepository;
            TransactionBookTableRepository = transactionBookTableRepository;
            TransactionContactUsRepository = transactionContactUsRepository;
            TransactionNewsletterRepository = transactionNewsletterRepository;
        }

        public IActionResult Index()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterCategoryMenu = MasterCategoryMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUsInformation = MasterContactUsInformationRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterItemMenu = MasterItemMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterMenu = MasterMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterOffer = MasterOfferRepository.GetAllClient()?.ToViewModelList(),
                MasterPartner = MasterPartnerRepository.GetAllClient()?.ToViewModelList(),
                MasterService = MasterServiceRepository.GetAllClient()?.ToViewModelList(),
                MasterSlider = MasterSliderRepository.GetAllClient()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterWorkingHour = MasterWorkingHourRepository.GetAllClient()?.ToViewModelList(),
                SystemSetting = SystemSettingRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                TransactionBookTable = TransactionBookTableRepository.GetAllClient()?.ToViewModelList(),
                TransactionContactUs = TransactionContactUsRepository.GetAllClient()?.ToViewModelList(),
                TransactionNewsletter = TransactionNewsletterRepository.GetAllClient()?.ToViewModelList()

            };
            return View(data);
        }
        public IActionResult About()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterCategoryMenu = MasterCategoryMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUsInformation = MasterContactUsInformationRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterItemMenu = MasterItemMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterMenu = MasterMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterOffer = MasterOfferRepository.GetAllClient()?.ToViewModelList(),
                MasterPartner = MasterPartnerRepository.GetAllClient()?.ToViewModelList(),
                MasterService = MasterServiceRepository.GetAllClient()?.ToViewModelList(),
                MasterSlider = MasterSliderRepository.GetAllClient()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterWorkingHour = MasterWorkingHourRepository.GetAllClient()?.ToViewModelList(),
                SystemSetting = SystemSettingRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                TransactionBookTable = TransactionBookTableRepository.GetAllClient()?.ToViewModelList(),
                TransactionContactUs = TransactionContactUsRepository.GetAllClient()?.ToViewModelList(),
                TransactionNewsletter = TransactionNewsletterRepository.GetAllClient()?.ToViewModelList()

            };
            return View(data);
        }
        public IActionResult Menu()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterCategoryMenu = MasterCategoryMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUsInformation = MasterContactUsInformationRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterItemMenu = MasterItemMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterMenu = MasterMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterOffer = MasterOfferRepository.GetAllClient()?.ToViewModelList(),
                MasterPartner = MasterPartnerRepository.GetAllClient()?.ToViewModelList(),
                MasterService = MasterServiceRepository.GetAllClient()?.ToViewModelList(),
                MasterSlider = MasterSliderRepository.GetAllClient()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterWorkingHour = MasterWorkingHourRepository.GetAllClient()?.ToViewModelList(),
                SystemSetting = SystemSettingRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                TransactionBookTable = TransactionBookTableRepository.GetAllClient()?.ToViewModelList(),
                TransactionContactUs = TransactionContactUsRepository.GetAllClient()?.ToViewModelList(),
                TransactionNewsletter = TransactionNewsletterRepository.GetAllClient()?.ToViewModelList()

            };
            return View(data);
        }
        public IActionResult Details()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterCategoryMenu = MasterCategoryMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUsInformation = MasterContactUsInformationRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterItemMenu = MasterItemMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterMenu = MasterMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterOffer = MasterOfferRepository.GetAllClient()?.ToViewModelList(),
                MasterPartner = MasterPartnerRepository.GetAllClient()?.ToViewModelList(),
                MasterService = MasterServiceRepository.GetAllClient()?.ToViewModelList(),
                MasterSlider = MasterSliderRepository.GetAllClient()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterWorkingHour = MasterWorkingHourRepository.GetAllClient()?.ToViewModelList(),
                SystemSetting = SystemSettingRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                TransactionBookTable = TransactionBookTableRepository.GetAllClient()?.ToViewModelList(),
                TransactionContactUs = TransactionContactUsRepository.GetAllClient()?.ToViewModelList(),
                TransactionNewsletter = TransactionNewsletterRepository.GetAllClient()?.ToViewModelList()

            };
            return View(data);
        }
        public IActionResult Contact()
        {
            var data = new HomeViewModel
            {
                MasterAbout = MasterAboutRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterCategoryMenu = MasterCategoryMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterContactUsInformation = MasterContactUsInformationRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                MasterItemMenu = MasterItemMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterMenu = MasterMenuRepository.GetAllClient()?.ToViewModelList(),
                MasterOffer = MasterOfferRepository.GetAllClient()?.ToViewModelList(),
                MasterPartner = MasterPartnerRepository.GetAllClient()?.ToViewModelList(),
                MasterService = MasterServiceRepository.GetAllClient()?.ToViewModelList(),
                MasterSlider = MasterSliderRepository.GetAllClient()?.ToViewModelList(),
                MasterSocialMedia = MasterSocialMediaRepository.GetAllClient()?.ToViewModelList(),
                MasterWorkingHour = MasterWorkingHourRepository.GetAllClient()?.ToViewModelList(),
                SystemSetting = SystemSettingRepository.GetAllClient()?.FirstOrDefault()?.ToViewModel(),
                TransactionBookTable = TransactionBookTableRepository.GetAllClient()?.ToViewModelList(),
                TransactionContactUs = TransactionContactUsRepository.GetAllClient()?.ToViewModelList(),
                TransactionNewsletter = TransactionNewsletterRepository.GetAllClient()?.ToViewModelList()

            };
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Subscribe(TransactionNewsletterViewModel collection)
        {
            try
            {
                var data = collection.ToModel();

                TransactionNewsletterRepository.Add(data);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Book(TransactionBookTableViewModel collection)
        {
            try
            {
                var data = collection.ToModel();

                TransactionBookTableRepository.Add(data);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendMessage(TransactionContactUsViewModel collection)
        {
            try
            {
                var data = collection.ToModel();

                TransactionContactUsRepository.Add(data);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
