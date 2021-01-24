using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

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


            return View(_DesktopService.GetAllViewModel());
        }

        public IActionResult Insert()
        {


            return View();
        }
    }
}
