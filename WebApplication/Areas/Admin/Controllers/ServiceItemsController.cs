using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Domain;
using WebApplication.Domain.Entities;
using WebApplication.Service;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
        public class ServiceItemsController : Controller
        {
            private readonly DataManager _dataManager;
            private readonly IWebHostEnvironment hostingEnvironment;
            public ServiceItemsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
            {
                this._dataManager = dataManager;
                this.hostingEnvironment = hostingEnvironment;
            }
            
            [Route("admin/ServiceItem/Edit")]
            public IActionResult Edit(Guid id)
            {
                var entity = id == default ? new ServiceItem() : _dataManager.ServiceItems.GetServiceItemById(id);
                return View(entity);
            }
            
            [HttpPost]
            [Route("admin/ServiceItem/Edit")]
            public IActionResult Edit(ServiceItem model)
            {
                if (ModelState.IsValid)
                {
                    _dataManager.ServiceItems.SaveServiceItem(model);
                    return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
                }
                return View(model);
            }

            [HttpPost]
            [Route("admin/ServiceItem/Delete")]
            public IActionResult Delete(Guid id)
            {
                _dataManager.ServiceItems.DeleteServiceItem(id);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
        }
}
    