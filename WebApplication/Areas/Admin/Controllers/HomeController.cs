using Microsoft.AspNetCore.Mvc;
using WebApplication.Domain;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [Route("/admin")]
        public IActionResult Index()
        {
            return View(_dataManager.ServiceItems.GetServiceItems());
        }
    }
}