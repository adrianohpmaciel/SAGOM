using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Produto
    {
        public Produto()
        {
            ProdutoOrdemDeServicos = new HashSet<ProdutoOrdemDeServico>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal? ValorUnitario { get; set; }

        public virtual ICollection<ProdutoOrdemDeServico> ProdutoOrdemDeServicos { get; set; }
    }
}
