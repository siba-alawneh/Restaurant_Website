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
    public class MasterPartnerController : Controller
    {
        IRepository<MasterPartner> Repository;
        IFileHelper FileHelper;

        public MasterPartnerController(IRepository<MasterPartner> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: MasterPartnerController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterPartnerFullViewModel
            {
                List = data
            };
            return View(obj);
        }

   
        public ActionResult CreateOrUpdate(MasterPartnerFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if (collection.Id == 0)
                {

                    data.CreateUser = User.Identity?.Name;

                    data.LogoImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterAboutImage");

                    if (data.LogoImageUrl != "Error")
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


                    if (collection.ImageFile != null)
                    {
                        data.LogoImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterAboutImage-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.LogoImageUrl = OldData.LogoImageUrl;
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


        // POST: MasterPartnerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterPartnerFullViewModel collection)
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

        public ActionResult ChangeStatus(int id, MasterPartnerFullViewModel collection)
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
