using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Website.Extensions.Mapping;
using Restaurant_Website.Models;
using Restaurant_Website.Repositories;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class MasterCategoryMenuController : Controller
    {
        IRepository<MasterCategoryMenu> Repository;

        public MasterCategoryMenuController(IRepository<MasterCategoryMenu> repository)
        {
            Repository = repository;
        }

        // GET: MasterCategoryMenuController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterCategoryMenuFullViewModel
            {
                List = data
            };
            return View(obj);
        }


        public ActionResult CreateOrUpdate(MasterCategoryMenuFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if (collection.Id == 0)
                { 
                    data.CreateUser = User.Identity?.Name;
                    Repository.Add(data);
                }
                else
                {
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

      

      

        // POST: MasterCategoryMenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterCategoryMenuFullViewModel collection)
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
        public ActionResult ChangeStatus(int id, MasterCategoryMenuFullViewModel collection)
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
