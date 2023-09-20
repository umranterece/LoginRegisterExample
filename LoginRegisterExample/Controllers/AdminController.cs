using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegisterExample.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        //[Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
