using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;
using Mis.Entities.Concrete;

namespace Mis.Web.Controllers
{
    public class DesktopsController : Controller
    {
        private IDesktopService _DesktopService;

        public DesktopsController(IDesktopService DesktopService)
        {
            _DesktopService = DesktopService;
        }


        public IActionResult Index()
        {
            //_DesktopService.Insert(new Desktop() { Id = 1 });

            return View(_DesktopService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
