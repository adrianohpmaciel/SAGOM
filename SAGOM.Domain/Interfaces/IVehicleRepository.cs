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
        Task<IEnumerable<Vehicle>> GetVehiclesByCostumer(Costumer costumer);
        //Task<IEnumerable<Vehicle>> GetVehiclesByModel(string model);
        //Task<IEnumerable<Vehicle>> GetVehiclesByBrand(string brand);
        //Task<IEnumerable<Vehicle>> GetVehiclesByIdCostumerService(Costumer costumer);
        Task<Vehicle?> GetVehicleByLicensePlateAndCountry(string licensePlate, string country);
        Task<Vehicle?> GetVehicleById(int id);
        Task<Vehicle?> Create(Vehicle vehicle);
        Task<Vehicle?> Update(Vehicle vehicle);
        Task<Vehicle?> Remove(Vehicle vehicle);
    }
}
