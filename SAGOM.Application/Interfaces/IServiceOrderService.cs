using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IServiceOrderService
    {
        Task<IEnumerable<ServiceOrderDTO>?> GetServiceOrdersByCostumerService(CostumerServiceDTO costumerService);
        Task<ServiceOrderDTO> GetServiceOrderById(int idServiceOrder);
        Task Add(ServiceOrderDTO serviceOrder);
        Task Update(ServiceOrderDTO serviceOrder);
        Task Remove(ServiceOrderDTO serviceOrder);
    }
}