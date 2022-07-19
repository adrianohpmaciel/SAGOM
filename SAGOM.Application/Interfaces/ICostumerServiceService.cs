using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface ICostumerServiceService
    {
        Task<IEnumerable<CostumerServiceDTO>?> GetCostumerServicesByVehicle(VehicleDTO vehicle);
        Task<IEnumerable<CostumerServiceDTO>?> GetCostumerServicesByDate(DateTime date);
        Task<CostumerServiceDTO> GetCostumerServiceById(int id);
        Task Add(CostumerServiceDTO costumerService);
        Task Update(CostumerServiceDTO costumerService);
        Task Remove(CostumerServiceDTO costumerService);
    }
}
