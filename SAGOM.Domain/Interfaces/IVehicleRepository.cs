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
        Task<IEnumerable<Vehicle>> GetAllVehicles();
        Task<IEnumerable<Vehicle>> GetVehicles(Costumer costumer);
        Task<IEnumerable<Vehicle>> GetVehiclesByModel(string model);
        Task<IEnumerable<Vehicle>> GetVehiclesByBrand(string brand);
        Task<IEnumerable<Vehicle>> GetVehiclesByIdCostumerService(Costumer costumer);
        Task<IEnumerable<Vehicle>> GetVehicleByLicensePlateAndCountry(string licensePlate, string country);
        Task<IEnumerable<Vehicle>> GetVehicleById(int id);
        Task<IEnumerable<Vehicle>> Create(Vehicle Vehicle);
        Task<IEnumerable<Vehicle>> Update(Vehicle Vehicle);
        Task<IEnumerable<Vehicle>> Remove(Vehicle Vehicle);
    }
}
