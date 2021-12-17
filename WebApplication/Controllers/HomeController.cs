using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using WebApplication.Domain;
using WebApplication.Domain.Entities;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
    
        public IActionResult Index()
        {
            var model = _dataManager.ServiceItems.GetServiceItems().OrderBy(x => x.NameChar);
            return View(model);
        }
        
    }
}