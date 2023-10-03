using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly List<Categoria> _categorias;

        public CategoriaRepository()
        {
            _categorias = new List<Categoria>();
        }

        public List<Categoria> ObterTodos()
        {
            return _categorias;
        }

        public Categoria ObterPorCodigo(int codigo)
        {
            return (_categorias.FirstOrDefault(c => c.Codigo == codigo));
        }

        public void Adicionar(Categoria categoria)
        {
            _categorias.Add(categoria);
        }

        public void Atualizar(Categoria categoriaAtualizar)
        {
            var categoriaExistente = _categorias.FirstOrDefault(c => c.Codigo == categoriaAtualizar.Codigo);

            if (categoriaExistente != null)
            {
                categoriaExistente.Codigo = categoriaAtualizar.Codigo;
            }
        }

        public void Remover(int codigo)
        {
            var categoriaExistente = _categorias.FirstOrDefault(c => c.Codigo == codigo);
            if (categoriaExistente != null)
            {
                _categorias.Remove(categoriaExistente);
            }
        }
    }
}
