using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Restaurant_Website.Extensions.Mapping;
using Restaurant_Website.Helpers.File;
using Restaurant_Website.Models;
using Restaurant_Website.Repositories;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterItemMenuController : Controller
    {
        IRepository<MasterItemMenu> Repository;
        IRepository<MasterCategoryMenu> CategoryRepository;
        IFileHelper FileHelper;


        public MasterItemMenuController(IRepository<MasterItemMenu> repository, IRepository<MasterCategoryMenu> categoryRepository, IFileHelper fileHelper)
        {
            Repository = repository;
            CategoryRepository = categoryRepository;
            FileHelper = fileHelper;
        }

        // GET: MasterItemMenuController
        public ActionResult Index()
        {
            var data = Repository.GetAll(x => x.MasterCategoryMenu).ToViewModelList();
            var categories = CategoryRepository.GetAll();

            var obj = new MasterItemMenuFullViewModel
            {
                List = data,
                CategoryDDL = new SelectList(
                categories,
                "Id",
                "MenuName"
        )
            };
            return View(obj);
        }

        

        // POST: MasterItemMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterItemMenuFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if (collection.Id == 0)
                {
                    data.CreateUser = User.Identity?.Name;

                    data.ImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterItemMenuImage");

                    if (data.ImageUrl != "Error")
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
                    var OldData = Repository.GetById(collection.Id);

                    if (collection.ImageFile != null && collection.ImageFile.Length > 0)
                    {
                        data.ImageUrl = FileHelper.SaveImage(collection.ImageFile, "MasterItemMenuImage-Updated");
                    }
                    else
                    {
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

        

        // POST: MasterItemMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterItemMenuFullViewModel collection)
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

        // POST: MasterItemMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, MasterItemMenuFullViewModel collection)
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
