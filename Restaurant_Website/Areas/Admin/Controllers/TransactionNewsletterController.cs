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
    public class TransactionNewsletterController : Controller
    {
        IRepository<TransactionNewsletter> Repository;

        public TransactionNewsletterController(IRepository<TransactionNewsletter> repository)
        {
            Repository = repository;
        }

        // GET: TransactionNewsletterController
        public ActionResult Index()
        {
            var data = Repository.GetAll().ToViewModelList();

            return View(data);
        }

        // POST: TransactionNewsletterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TransactionNewsletterViewModel collection)
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
        // POST: TransactionNewsletterController/ChangeStatus/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeStatus(int id, TransactionNewsletterViewModel collection)
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
