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
        Task<IEnumerable<Service>> GetServiceServiceOrdersByServiceAsync(Service service);
        Task<IEnumerable<Service>> GetServiceServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder);
        Task<Service> GetServiceServiceOrderById(int id);
        Task<Service> CreateAsync(Service service);
        Task<Service> UpdateAsync(Service service);
        Task<Service> RemoveAsync(Service service);
    }
}