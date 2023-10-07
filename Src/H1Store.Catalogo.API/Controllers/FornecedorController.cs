using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.Services;
using H1Store.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace H1Store.Catalogo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpPost(Name = "AdicionarFornecedor")]
        public IActionResult Post(NovoFornecedorViewModel novoFornecedorViewModel)
        {
            _fornecedorService.AdicionarFornecedor(novoFornecedorViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodosFornecedor")]
        public IActionResult Get()
        {
            return Ok(_fornecedorService.ObterTodosFornecedor());
        }
    }
}
