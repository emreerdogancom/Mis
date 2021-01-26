using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class TabletsController : Controller
    {
        private ITabletService _tabletService;

        public TabletsController(ITabletService Service)
        {
            _tabletService = Service;
        }


        public IActionResult Index()
        {
            return View(_tabletService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
