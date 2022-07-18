using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Cargo
    {
        public Cargo()
        {
            Colaboradors = new HashSet<Colaborador>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public virtual ICollection<Colaborador> Colaboradors { get; set; }
    }
}
