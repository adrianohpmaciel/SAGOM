using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Cliente
    {
        public Cliente()
        {
            Atendimentos = new HashSet<Atendimento>();
            Veiculos = new HashSet<Veiculo>();
        }

        public int Id { get; set; }
        public string? Cpf { get; set; }

        public virtual Pessoa? CpfNavigation { get; set; }
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
    }
}
