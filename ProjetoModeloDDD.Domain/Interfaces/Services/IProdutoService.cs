using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);
    }
}
