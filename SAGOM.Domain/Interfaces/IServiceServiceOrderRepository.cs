using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IServiceServiceOrderRepository
    {
        //Task<IEnumerable<Service>> GetServiceServiceOrdersByServiceAsync(Service service);
        Task<IEnumerable<ServiceServiceOrder>?> GetServiceServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder);
        Task<ServiceServiceOrder> GetServiceServiceOrderByIdAsync(int id);
        Task<ServiceServiceOrder> CreateAsync(ServiceServiceOrder service);
        Task<ServiceServiceOrder> UpdateAsync(ServiceServiceOrder service);
        Task<ServiceServiceOrder> RemoveAsync(ServiceServiceOrder service);
    }
}