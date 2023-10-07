using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.Services;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost(Name = "AdicionarCategoria")]
        public IActionResult Post(NovaCategoriaViewModel novaCategoriaViewModel)
        {
            _categoriaService.AdicionarCategoria(novaCategoriaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodasCategorias")]
        public IActionResult Get()
        {
            return Ok(_categoriaService.ObterTodasCategorias());
        }
    }
}
