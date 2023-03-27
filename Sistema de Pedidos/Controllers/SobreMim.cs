using Microsoft.AspNetCore.Mvc;

namespace Sistema_de_Pedidos.Controllers
{
    public class SobreMim : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
