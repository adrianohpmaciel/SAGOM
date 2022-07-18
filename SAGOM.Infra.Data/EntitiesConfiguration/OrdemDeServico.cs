using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class OrdemDeServico
    {
        public OrdemDeServico()
        {
            ProdutoOrdemDeServicos = new HashSet<ProdutoOrdemDeServico>();
            ServicoOrdemDeServicos = new HashSet<ServicoOrdemDeServico>();
        }

        public int Id { get; set; }
        public int? IdAtendimento { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataUltimaAlteracaoStatus { get; set; }
        public string? Motivo { get; set; }
        public string? Status { get; set; }

        public virtual Atendimento? IdAtendimentoNavigation { get; set; }
        public virtual ICollection<ProdutoOrdemDeServico> ProdutoOrdemDeServicos { get; set; }
        public virtual ICollection<ServicoOrdemDeServico> ServicoOrdemDeServicos { get; set; }
    }
}
