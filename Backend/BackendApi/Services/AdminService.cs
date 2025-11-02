using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Services
{
    public class AdminService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
