using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class ProdutoOrdemDeServico
    {
        public int Id { get; set; }
        public int? IdProduto { get; set; }
        public int? IdOrdemServico { get; set; }
        public short? Quantidade { get; set; }

        public virtual OrdemDeServico? IdOrdemServicoNavigation { get; set; }
        public virtual Produto? IdProdutoNavigation { get; set; }
    }
}
