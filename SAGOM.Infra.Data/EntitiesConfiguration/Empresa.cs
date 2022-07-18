using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Empresa
    {
        public Empresa()
        {
            Colaboradors = new HashSet<Colaborador>();
            Conta = new HashSet<Conta>();
        }

        public string Cnpj { get; set; } = null!;
        public string? NomeFantasia { get; set; }
        public string? Endereço { get; set; }
        public string? Telefone { get; set; }

        public virtual ICollection<Colaborador> Colaboradors { get; set; }
        public virtual ICollection<Conta> Conta { get; set; }
    }
}
