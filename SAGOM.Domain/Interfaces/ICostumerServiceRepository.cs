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
        //Task<IEnumerable<CostumerService>> GetCostumerServicesByCostumerAsync(Costumer costumer);
        //Task<IEnumerable<CostumerService>> GetCostumerServicesByEmployeeAsync(Employee employee);
        Task<IEnumerable<CostumerService>?> GetCostumerServicesByVehicleAsync(Vehicle vehicle);
        Task<IEnumerable<CostumerService>?> GetCostumerServicesByDateAsync(DateTime date);
        Task<CostumerService?> GetCostumerServiceByIdAsync(int id);
        Task<CostumerService> CreateAsync(CostumerService costumerService);
        Task<CostumerService?> UpdateAsync(CostumerService costumerService);
        Task<CostumerService?> RemoveAsync(CostumerService costumerService);
    }
}
