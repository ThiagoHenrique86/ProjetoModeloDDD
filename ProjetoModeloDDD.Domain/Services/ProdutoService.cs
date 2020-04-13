using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produtos>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRespository;

        public ProdutoService(IProdutoRepository produtoRespository) 
            : base(produtoRespository)
        {
            _produtoRespository = produtoRespository;
        }

        public IEnumerable<Produtos> BuscarPorNome(string nome)
        {
            return _produtoRespository.BuscarPorNome(nome);
        }
    }
}
