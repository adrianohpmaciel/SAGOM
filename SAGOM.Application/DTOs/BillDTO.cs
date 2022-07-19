using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public sealed class BillDTO
    {
        public int Id { get; private set; }
        public string CnpjReceiver { get; private set; } = null!;
        public string? CnpjPayer { get; private set; }
        public string? CpfPayer { get; private set; }
        public string? Description { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        public string Status { get; private set; } = null!;


    }
}
