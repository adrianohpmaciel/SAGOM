using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class ServiceOrder
    {
        public ServiceOrder()
        {
            ProdutoOrdemDeServicos = new HashSet<ProductServiceOrder>();
            ServicoOrdemDeServicos = new HashSet<ServiceServiceOrder>();
        }

        public int Id { get; set; }
        public int? IdCostumerService { get; set; }
        public DateTime Date { get; set; }
        public DateTime? UpdateDateLastStatus { get; set; }
        public string Reason { get; set; } = null!;
        public string Status { get; set; } = null!;

        public  CostumerService? IdAtendimentoNavigation { get; set; }
        public  ICollection<ProductServiceOrder> ProdutoOrdemDeServicos { get; set; }
        public  ICollection<ServiceServiceOrder> ServicoOrdemDeServicos { get; set; }
    }
}
