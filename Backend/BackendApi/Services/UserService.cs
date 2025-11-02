using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Services
{
    public class UserService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
