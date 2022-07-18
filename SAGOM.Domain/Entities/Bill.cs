using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Bill
    {
        public int Id { get; private set; }
        public string CnpjReceiverCompany { get; private set; }
        public string? CnpjPayerCompany { get; private set; }
        public string? CpfPayer { get; private set; }
        public string? Description { get; private set; }
        public decimal Value { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime? DueDate { get; private set; }
        public DateTime? PaymentDate { get; private set; }
        public string Status { get; private set; }

        public Company CnpjReceiverCompanyNavigation { get; private set; }


    }
}
