using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Contum
    {
        public int Id { get; set; }
        public string CnpjRecebedor { get; set; } = null!;
        public string? CnpjPagante { get; set; }
        public string? CpfPagante { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string Status { get; set; } = null!;

        public virtual Empresa CnpjRecebedorNavigation { get; set; } = null!;
        public virtual Atendimento IdNavigation { get; set; } = null!;
    }
}
