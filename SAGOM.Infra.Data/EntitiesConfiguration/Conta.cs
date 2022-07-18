using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Conta
    {
        public int Id { get; set; }
        public string? CnpjRecebedor { get; set; }
        public string? CnpjPagante { get; set; }
        public string? CpfPagante { get; set; }
        public string? Descricao { get; set; }
        public decimal? Valor { get; set; }
        public DateTime Data { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? Status { get; set; }

        public virtual Empresa? CnpjRecebedorNavigation { get; set; }
    }
}
