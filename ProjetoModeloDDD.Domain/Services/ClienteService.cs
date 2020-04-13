﻿using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Services
{
    
    public class ClienteService : ServiceBase<Clientes>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
            : base (clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Clientes> ObterClientesEspeciais(IEnumerable<Clientes> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
