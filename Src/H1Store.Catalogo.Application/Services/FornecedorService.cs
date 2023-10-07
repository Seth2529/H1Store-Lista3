using AutoMapper;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.Services
{
    public class FornecedorService:IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorServices;
        private IMapper _mapper;

        public FornecedorService(IFornecedorRepository fornecedorServices, IMapper mapper)
        {
            _fornecedorServices = fornecedorServices;
            _mapper = mapper;
        }

        public List<FornecedorViewModel> ObterTodosFornecedor()
        {
            return _mapper.Map<List<FornecedorViewModel>>(_fornecedorServices.ObterTodos());
        }

        public void AdicionarFornecedor(NovoFornecedorViewModel novoFornecedorViewModel)
        {
            var novaCategoria = _mapper.Map<Fornecedor>(novoFornecedorViewModel);
            _fornecedorServices.Adicionar(novaCategoria);
        }
        public FornecedorViewModel ObterFornecedorPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
        public void AtualizarFornecedor(FornecedorViewModel fornecedor)
        {
            throw new NotImplementedException();
        }
        public void RemoverFornecedor(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
