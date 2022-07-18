using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Empresa
    {
        public Empresa()
        {
            Colaboradors = new HashSet<Colaborador>();
            Conta = new HashSet<Contum>();
        }

        public string Cnpj { get; set; } = null!;
        public string NomeFantasia { get; set; } = null!;
        public string Endereço { get; set; } = null!;
        public string Telefone { get; set; } = null!;

        public virtual ICollection<Colaborador> Colaboradors { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
    }
}
