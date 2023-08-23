using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class FormacoesController : Controller
    {
        public IActionResult Index() {
            return View();
        }
    }
}
