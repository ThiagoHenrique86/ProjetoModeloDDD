using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produtos>
    {
        IEnumerable<Produtos> BuscarPorNome(string nome);
    }
}
