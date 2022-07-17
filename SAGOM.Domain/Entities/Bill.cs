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
        public Company ReceiverCompany { get; private set; }
        public Company PayerCompany { get; private set; }
        public Person Payer { get; private set; } 
        public string Description { get; private set; }
        public double Value { get; private set; }
        public DateTime Date { get; private set; }
        public DateTime DueDate { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public string Status { get; private set; }

    }
}
