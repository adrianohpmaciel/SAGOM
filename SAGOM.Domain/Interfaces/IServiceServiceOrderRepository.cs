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
        Task<IEnumerable<Service>> GetAllServiceServiceOrdersAsync();
        Task<IEnumerable<Service>> GetServiceServiceOrdersByServiceAsync(Service service);
        Task<IEnumerable<Service>> GetServiceServiceOrdersByServiceOrderAsync(ServiceOrder serviceOrder);
        Task<IEnumerable<Service>> GetServiceServiceOrderById(int id);
        Task<IEnumerable<Service>> CreateAsync(Service service);
        Task<IEnumerable<Service>> UpdateAsync(Service service);
        Task<IEnumerable<Service>> RemoveAsync(Service service);
    }
}