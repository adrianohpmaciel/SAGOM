using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetServicesAsync();
        Task<IEnumerable<Service>> GetServicesByNameAsync(string name);
        Task<IEnumerable<Service>> GetServiceByIdAsync(int idService);
        Task<IEnumerable<Service>> CreateAsync(Service service);
        Task<IEnumerable<Service>> UpdateAsync(Service service);
        Task<IEnumerable<Service>> RemoveAsync(Service service);
    }
}