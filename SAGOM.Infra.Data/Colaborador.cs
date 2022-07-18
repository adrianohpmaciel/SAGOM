using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Colaborador
    {
        public Colaborador()
        {
            Atendimentos = new HashSet<Atendimento>();
            Ferramenta = new HashSet<Ferramentum>();
        }

        public int Id { get; set; }
        public string? Cpf { get; set; }
        public int IdCargo { get; set; }
        public decimal? Salario { get; set; }
        public string? CnpjEmpresa { get; set; }

        public virtual Empresa? CnpjEmpresaNavigation { get; set; }
        public virtual ICollection<Atendimento> Atendimentos { get; set; }
        public virtual ICollection<Ferramentum> Ferramenta { get; set; }
    }
}
