using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;


namespace ProjetoModeloDDD.Application
{
   public class ClienteAppService : AppServiceBase<Clientes>, IClienteAppService
    {

        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) 
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Clientes> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
