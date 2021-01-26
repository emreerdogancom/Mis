using Microsoft.AspNetCore.Mvc;
using Mis.Business.Abstract;

namespace Mis.Web.Controllers
{
    public class ServersController : Controller
    {
        private IServerService _serverService;

        public ServersController(IServerService Service)
        {
            _serverService = Service;
        }


        public IActionResult Index()
        {
            return View(_serverService.GetAllViewModel());
        }

        public IActionResult Insert()
        {
            return View();
        }
    }
}
