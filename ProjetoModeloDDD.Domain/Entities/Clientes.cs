using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produtos> Produtos { get; set; }

        public bool ClienteEspecial(Clientes cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

    }
}


