using H1Store.Catalogo.Application.ViewModels;
using H1Store.Catalogo.Application.Interfaces;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using H1Store.Catalogo.Domain.Entities;

namespace H1Store.Catalogo.Application.Services
{
    public class CategoriaService: ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaServices;
        private IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaServices, IMapper mapper)
        {
            _categoriaServices = categoriaServices;
            _mapper = mapper;
        }

        public List<CategoriaViewModel> ObterTodasCategorias()
        {
            return _mapper.Map<List<CategoriaViewModel>>(_categoriaServices.ObterTodas());
        }

        public void AdicionarCategoria(NovaCategoriaViewModel novaCategoriaViewModel)
        {
            var novaCategoria = _mapper.Map<Categoria>(novaCategoriaViewModel);
            _categoriaServices.Adicionar(novaCategoria);
        }

        public CategoriaViewModel ObterCategoriaPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
        public void AtualizarCategoria(CategoriaViewModel categoria)
        {
            throw new NotImplementedException();
        }
        public void RemoverCategoria(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
