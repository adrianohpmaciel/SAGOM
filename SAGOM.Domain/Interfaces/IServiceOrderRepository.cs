using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IServiceOrderRepository
    {
        Task<IEnumerable<ServiceOrder>> GetServiceOrdersAsync();
        Task<IEnumerable<ServiceOrder>> GetServiceOrdersByIdCostumerService(int idCostumerService);
        Task<IEnumerable<CostumerService>> GetServicesOrdersByDataAsync(DateTime data);
        Task<IEnumerable<ServiceOrder>> GetServiceOrderByIdAsync(int idServiceOrder);
        Task<IEnumerable<ServiceOrder>> CreateAsync(ServiceOrder serviceOrder);
        Task<IEnumerable<ServiceOrder>> UpdateAsync(ServiceOrder serviceOrder);
        Task<IEnumerable<ServiceOrder>> RemoveAsync(ServiceOrder serviceOrder);
    }
}