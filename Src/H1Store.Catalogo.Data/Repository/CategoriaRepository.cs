using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string _categoriasCaminhoArquivo;

        #region Construtores
        public CategoriaRepository()
        {
            _categoriasCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "categoria.json");
        }

        #endregion

        #region Métodos
        public List<Categoria> ObterTodasAsCategorias()
        {
            if (!System.IO.File.Exists(_categoriasCaminhoArquivo))
            {
                return new List<Categoria>();
            }
            Directory.CreateDirectory(_categoriasCaminhoArquivo.Substring(0, _categoriasCaminhoArquivo.LastIndexOf('\\') + 1));
            string Readjson = System.IO.File.ReadAllText(_categoriasCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Categoria>>(Readjson);
        }

        public void AdicionarCategoria(List<Categoria> categoria)
        {
            string Readjson = JsonConvert.SerializeObject(categoria);
            System.IO.File.WriteAllText(_categoriasCaminhoArquivo, Readjson);
        }
        #endregion

        public List<Categoria> ObterTodas()
        {
            List<Categoria> obter = ObterTodasAsCategorias();
            List<Categoria> enumerar = obter;
            return enumerar;
        }

        public Categoria ObterPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public void Adicionar(Categoria categoria)
        {
            List<Categoria> novaCategoria = ObterTodasAsCategorias();
            novaCategoria.Add(categoria);
            AdicionarCategoria(novaCategoria);
        }

        public void Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void Remover(int codigo)
        {
            throw new NotImplementedException();
        }
    }

}
