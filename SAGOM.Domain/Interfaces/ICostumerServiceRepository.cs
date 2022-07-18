using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface ICostumerServiceRepository
    {
        Task<IEnumerable<CostumerService>> GetCostumerServicesAsync();
        Task<IEnumerable<CostumerService>> GetCostumerServicesByClientAsync(Client client);
        Task<IEnumerable<CostumerService>> GetCostumerServicesByEmployeeAsync(Employee employee);
        Task<IEnumerable<CostumerService>> GetCostumerServicesByVehicleAsync(Vehicle vehicle);
        Task<IEnumerable<CostumerService>> GetCostumerServicesByDataAsync(DateTime data);
        Task<IEnumerable<CostumerService>> GetCostumerServiceByIdAsync(int id);
        Task<IEnumerable<CostumerService>> CreateAsync(CostumerService costumerService);
        Task<IEnumerable<CostumerService>> UpdateAsync(CostumerService costumerService);
        Task<IEnumerable<CostumerService>> RemoveAsync(CostumerService costumerService);
    }
}
