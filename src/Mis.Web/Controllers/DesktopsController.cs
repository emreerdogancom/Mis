using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;
using Mis.Entities.Concrete;

namespace Mis.Web.Controllers
{
    public class DesktopsController : Controller
    {
        private IDesktopService _desktopService;

        public DesktopsController(IDesktopService Service)
        {
            _desktopService = Service;
        }


        public IActionResult Index()
        {
            //_DesktopService.Insert(new Desktop() { Id = 1 });

            return View(_desktopService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
