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
        Task<IEnumerable<ServiceOrder>> GetServiceOrdersByIdCostumerService(int idCostumerService);
        Task<IEnumerable<ServiceOrder>> GetServicesOrdersByDataAsync(DateTime data);
        Task<IEnumerable<ServiceOrder>> GetServiceOrderByIdAsync(int idServiceOrder);
        Task<ServiceOrder>CreateAsync(ServiceOrder serviceOrder);
        Task<ServiceOrder>UpdateAsync(ServiceOrder serviceOrder);
        Task<ServiceOrder>RemoveAsync(ServiceOrder serviceOrder);
    }
}