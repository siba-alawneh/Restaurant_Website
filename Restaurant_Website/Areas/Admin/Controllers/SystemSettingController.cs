using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Website.Extensions.Mapping;
using Restaurant_Website.Helpers.File;
using Restaurant_Website.Models;
using Restaurant_Website.Repositories;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class SystemSettingController : Controller
    {
        IRepository<SystemSetting> Repository;
        IFileHelper FileHelper;

        public SystemSettingController(IRepository<SystemSetting> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: SystemSettingController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new SystemSettingFullViewModel
            {
                List = data
            };
            ViewBag.HasAnyRecord = data.Count > 0;
            return View(obj);
        }

       
        // POST: SystemSettingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(SystemSettingFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if(data.Id == 0)
                {
                    data.CreateUser = User.Identity?.Name;

                    data.LogoImageUrl = FileHelper.SaveImage(collection.LogoImageFile, "SystemSettingImage");
                    data.LogoImageUrl2 = FileHelper.SaveImage(collection.LogoImageFile2, "SystemSettingImage");
                    data.WelcomeNoteImageUrl = FileHelper.SaveImage(collection.ImageFile1, "SystemSettingImage");
                    data.WelcomeNoteImageUrl2 = FileHelper.SaveImage(collection.ImageFile2, "SystemSettingImage");
                    data.WelcomeNoteImageUrl3 = FileHelper.SaveImage(collection.ImageFile3, "SystemSettingImage");
                    data.WelcomeNoteImageUrl4 = FileHelper.SaveImage(collection.ImageFile4, "SystemSettingImage");

                    if (data.LogoImageUrl != "Error" && data.LogoImageUrl2 != "Error" && data.WelcomeNoteImageUrl != "Error" && data.WelcomeNoteImageUrl2 != "Error" && data.WelcomeNoteImageUrl3 != "Error" && data.WelcomeNoteImageUrl4 != "Error")
                    {
                        Repository.Add(data);
                    }
                    else
                    {
                        return View(collection);
                    }
                }
                else
                {
                    if (collection.LogoImageFile != null)
                    {
                        data.LogoImageUrl = FileHelper.SaveImage(collection.LogoImageFile, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.LogoImageUrl = OldData.LogoImageUrl;
                    }
                    if (collection.LogoImageFile2 != null)
                    {
                        data.LogoImageUrl2 = FileHelper.SaveImage(collection.LogoImageFile2, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.LogoImageUrl2 = OldData.LogoImageUrl2;
                    }
                    if (collection.ImageFile1 != null)
                    {
                        data.WelcomeNoteImageUrl = FileHelper.SaveImage(collection.ImageFile1, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.WelcomeNoteImageUrl = OldData.WelcomeNoteImageUrl;
                    }
                    if (collection.ImageFile2 != null)
                    {
                        data.WelcomeNoteImageUrl2 = FileHelper.SaveImage(collection.ImageFile2, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.WelcomeNoteImageUrl2 = OldData.WelcomeNoteImageUrl2;
                    }
                    if (collection.ImageFile3 != null)
                    {
                        data.WelcomeNoteImageUrl3 = FileHelper.SaveImage(collection.ImageFile3, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.WelcomeNoteImageUrl3 = OldData.WelcomeNoteImageUrl3;
                    }
                    if (collection.ImageFile4 != null)
                    {
                        data.WelcomeNoteImageUrl4 = FileHelper.SaveImage(collection.ImageFile4, "SystemSetting-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.WelcomeNoteImageUrl4 = OldData.WelcomeNoteImageUrl4;
                    }

                    data.CreateUser = Repository.GetById(collection.Id).CreateUser;
                    data.CreateDate = Repository.GetById(collection.Id).CreateDate;
                    data.EditUser = User.Identity?.Name;
                    Repository.Update(data);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        // POST: SystemSettingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SystemSettingFullViewModel collection)
        {
            try
            {
                Repository.Delete(collection.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: SystemSettingController/ChangeStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, SystemSettingFullViewModel collection)
        {
            try
            {
                Repository.ChangeStatus(collection.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
