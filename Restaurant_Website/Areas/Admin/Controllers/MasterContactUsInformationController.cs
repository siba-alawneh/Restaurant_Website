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
    public class MasterContactUsInformationController : Controller
    {
        IRepository<MasterContactUsInformation> Repository;

        public MasterContactUsInformationController(IRepository<MasterContactUsInformation> repository)
        {
            Repository = repository;
        }

        // GET: MasterContactUsInformationController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterContactUsInformationFullViewModel
            {
                List = data
            };
            ViewBag.HasAnyRecord = data.Count > 0;
            return View(obj);
        }



        // POST: MasterContactUsInformationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterContactUsInformationFullViewModel collection)
        {
            try
            {
                var data = collection.ToFullModel();
                if(collection.Id == 0)
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

      

        // POST: MasterContactUsInformationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterContactUsInformationFullViewModel collection)
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
