using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Bill
    {
        public int Id { get; set; }
        public string CnpjReceiver { get; set; } = null!;
        public string? CnpjPayer { get; set; }
        public string? CpfPayer { get; set; }
        public string? Description { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Status { get; set; } = null!;

        public  Company CnpjRecebedorNavigation { get; set; } = null!;
        public  CostumerService IdNavigation { get; set; } = null!;


    }
}
