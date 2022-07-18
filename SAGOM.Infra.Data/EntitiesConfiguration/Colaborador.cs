using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Colaborador
    {
        public Colaborador()
        {
            Atendimentos = new HashSet<Atendimento>();
            Ferramenta = new HashSet<Ferramenta>();
        }

        public int Id { get; set; }
        public string? Cpf { get; set; }
        public int IdCargo { get; set; }
        public decimal? Salario { get; set; }
        public string? CnpjEmpresa { get; set; }

        public virtual Empresa? CnpjEmpresaNavigation { get; set; }
        public virtual Pessoa? CpfNavigation { get; set; }
        public virtual Cargo IdCargoNavigation { get; set; } = null!;
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
        public virtual ICollection<Ferramenta> Ferramenta { get; set; }
    }
}
