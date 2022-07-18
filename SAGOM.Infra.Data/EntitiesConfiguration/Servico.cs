using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Servico
    {
        public Servico()
        {
            ServicoOrdemDeServicos = new HashSet<ServicoOrdemDeServico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }

        public virtual ICollection<ServicoOrdemDeServico> ServicoOrdemDeServicos { get; set; }
    }
}
