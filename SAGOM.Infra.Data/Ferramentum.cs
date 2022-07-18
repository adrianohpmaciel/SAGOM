using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Ferramentum
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? DataDeCompra { get; set; }
        public DateTime? DataDeDescarte { get; set; }
        public string Status { get; set; } = null!;
        public int? IdColaborador { get; set; }

        public virtual Colaborador? IdColaboradorNavigation { get; set; }
    }
}
