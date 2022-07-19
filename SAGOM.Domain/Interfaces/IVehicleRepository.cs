using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetVehiclesByCostumerAsync(Costumer costumer);
        //Task<IEnumerable<Vehicle>> GetVehiclesByModel(string model);
        //Task<IEnumerable<Vehicle>> GetVehiclesByBrand(string brand);
        //Task<IEnumerable<Vehicle>> GetVehiclesByIdCostumerService(Costumer costumer);
        Task<Vehicle?> GetVehicleByLicensePlateAndCountryAsync(string licensePlate, string country);
        Task<Vehicle?> GetVehicleByIdAsync(int id);
        Task<Vehicle?> CreateAsync(Vehicle vehicle);
        Task<Vehicle?> UpdateAsync(Vehicle vehicle);
        Task<Vehicle?> RemoveAsync(Vehicle vehicle);
    }
}
