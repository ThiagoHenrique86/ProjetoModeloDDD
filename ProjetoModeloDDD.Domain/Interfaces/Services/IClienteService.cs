using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Clientes>
    {
        IEnumerable<Clientes> ObterClientesEspeciais(IEnumerable<Clientes> clientes);

    }
}
