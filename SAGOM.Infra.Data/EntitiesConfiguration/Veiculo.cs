using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Veiculo
    {
        public Veiculo()
        {
            Atendimentos = new HashSet<Atendimento>();
        }

        public int Id { get; set; }
        public string Placa { get; set; } = null!;
        public string País { get; set; } = null!;
        public string? Estado { get; set; }
        public short? Ano { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
    }
}
