using H1Store.Catalogo.Domain.Entities;
using H1Store.Catalogo.Domain.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Data.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly string _fornecedoresCaminhoArquivo;

        #region Construtores
        public FornecedorRepository()    
        {
            _fornecedoresCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "fornecedor.json");
        }

        #endregion

        #region Métodos
        public List<Fornecedor> ObterTodosOsFornecedors()
        {
            if (!System.IO.File.Exists(_fornecedoresCaminhoArquivo))
            {
                return new List<Fornecedor>();
            }
            Directory.CreateDirectory(_fornecedoresCaminhoArquivo.Substring(0, _fornecedoresCaminhoArquivo.LastIndexOf('\\') + 1));
            string Readjson = System.IO.File.ReadAllText(_fornecedoresCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Fornecedor>>(Readjson);
        }

        public void AdicionarFornecedor(List<Fornecedor> Fornecedor)
        {
            string Readjson = JsonConvert.SerializeObject(Fornecedor);
            System.IO.File.WriteAllText(_fornecedoresCaminhoArquivo, Readjson);
        }
        #endregion

        public List<Fornecedor> ObterTodos()
        {
            List<Fornecedor> obter = ObterTodosOsFornecedors();
            List<Fornecedor> enumerar = obter;
            return enumerar;
        }
        public Fornecedor ObterPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }
        public void Adicionar(Fornecedor fornecedor)
        {
            List<Fornecedor> novoFornecedor = ObterTodosOsFornecedors();
            novoFornecedor.Add(fornecedor);
            AdicionarFornecedor(novoFornecedor);
        }
        public void Atualizar(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void Remover(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
