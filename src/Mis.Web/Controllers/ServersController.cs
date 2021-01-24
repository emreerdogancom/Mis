using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class ServersController : Controller
    {
        private IServerService _ServerService;

        public ServersController(IServerService ServerService)
        {
            _ServerService = ServerService;
        }


        public IActionResult Index()
        {
            return View(_ServerService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
