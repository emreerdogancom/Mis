using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class TabletsController : Controller
    {
        private ITabletService _TabletService;

        public TabletsController(ITabletService TabletService)
        {
            _TabletService = TabletService;
        }


        public IActionResult Index()
        {
            return View(_TabletService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
