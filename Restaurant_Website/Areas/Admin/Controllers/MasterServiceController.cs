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
    public class MasterServiceController : Controller
    {
        IRepository<MasterService> Repository;

        public MasterServiceController(IRepository<MasterService> repository)
        {
            Repository = repository;
        }

        // GET: MasterServiceController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();
            var obj = new MasterServiceFullViewModel
            {
                List = data,
            };
            return View(obj);
        }


        // POST: MasterServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrUpdate(MasterServiceFullViewModel collection)
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



        // POST: MasterServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, MasterServiceFullViewModel collection)
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
        // POST: MasterServiceController/ChangeStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, MasterServiceFullViewModel collection)
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
