using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class ServicoOrdemDeServico
    {
        public int Id { get; set; }
        public int? IdServico { get; set; }
        public int? IdOrdemServico { get; set; }

        public virtual OrdemDeServico? IdOrdemServicoNavigation { get; set; }
        public virtual Servico? IdServicoNavigation { get; set; }
    }
}
