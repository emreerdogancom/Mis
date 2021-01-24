using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class LaptopsController : Controller
    {
        private ILaptopService _LaptopService;

        public LaptopsController(ILaptopService LaptopService)
        {
            _LaptopService = LaptopService;
        }

        public IActionResult Index()
        {
            return View(_LaptopService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
