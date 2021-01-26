using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class LaptopsController : Controller
    {
        private ILaptopService _laptopService;

        public LaptopsController(ILaptopService Service)
        {
            _laptopService = Service;
        }

        public IActionResult Index()
        {
            return View(_laptopService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
