using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Atendimento
    {
        public Atendimento()
        {
            OrdemDeServicos = new HashSet<OrdemDeServico>();
        }

        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdColaborador { get; set; }
        public int? IdVeiculo { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataUltimaAlteracaoStatus { get; set; }
        public string DescricaoProblema { get; set; } = null!;
        public string Status { get; set; } = null!;
        public int? IdConta { get; set; }

        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Colaborador? IdColaboradorNavigation { get; set; }
        public virtual Veiculo? IdVeiculoNavigation { get; set; }
        public virtual Contum Contum { get; set; } = null!;
        public virtual ICollection<OrdemDeServico> OrdemDeServicos { get; set; }
    }
}
