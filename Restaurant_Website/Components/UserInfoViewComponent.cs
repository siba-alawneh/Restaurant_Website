using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Website.Components
{
    public class UserInfoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Default", User.Identity?.Name);
        }
    }
}
