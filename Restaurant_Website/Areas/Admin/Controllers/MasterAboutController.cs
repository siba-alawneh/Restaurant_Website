using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Restaurant_Website.Extensions.Mapping;
using Restaurant_Website.Helpers.File;
using Restaurant_Website.Models;
using Restaurant_Website.Repositories;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterAboutController : Controller
    {
        IRepository<MasterAbout> Repository;
        IFileHelper FileHelper;

        public MasterAboutController(IRepository<MasterAbout> repository, IFileHelper fileHelper)
        {
            Repository = repository;
            FileHelper = fileHelper;
        }

        // GET: MasterAboutController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterAboutFullViewModel
            {
                List = data
            };
            ViewBag.HasAnyRecord = data.Count > 0;
            return View(obj);
        }

        public ActionResult CreateOrUpdate(MasterAboutFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if (collection.Id == 0)
                {
                   
                    data.CreateUser= User.Identity?.Name;
                    
                    data.ImageUrl= FileHelper.SaveImage(collection.ImageFile, "MasterAboutImage");

                    if(data.ImageUrl!="Error")
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
                   

                    if(collection.ImageFile != null) 
                    {
                        data.ImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterAboutImage-Updated");
                    }
                    else
                    {
                        var OldData = Repository.GetById(collection.Id);
                        data.ImageUrl = OldData.ImageUrl;
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

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterAboutFullViewModel collection)
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

        // POST: MasterAboutController/ChangeStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, MasterAboutFullViewModel collection)
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
