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
    public class TransactionContactUsController : Controller
    {
        IRepository<TransactionContactUs> Repository;

        public TransactionContactUsController(IRepository<TransactionContactUs> repository)
        {
            Repository = repository;
        }

        // GET: TransactionContactUsController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();

            return View(data);
        }

        // POST: TransactionContactUsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TransactionContactUsViewModel collection)
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

        // POST: TransactionContactUsController/ChangeStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, TransactionContactUsViewModel collection)
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
