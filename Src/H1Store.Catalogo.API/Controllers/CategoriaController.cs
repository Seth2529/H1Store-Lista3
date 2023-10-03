using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
