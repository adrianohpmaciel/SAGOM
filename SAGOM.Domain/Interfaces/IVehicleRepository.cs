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
        Task<IEnumerable<Vehicle>> GetAllVehiclesByModel(string model);
        Task<IEnumerable<Vehicle>> GetAllVehiclesByBrand(string brand);
        Task<IEnumerable<Vehicle>> GetVehicleByLicensePlateAndCountry(string licensePlate, string country);
        Task<IEnumerable<Vehicle>> GetVehicleByLicensePlateAndCountry(int id);
        Task<IEnumerable<Vehicle>> Create(Vehicle Vehicle);
        Task<IEnumerable<Vehicle>> Update(Vehicle Vehicle);
        Task<IEnumerable<Vehicle>> Remove(Vehicle Vehicle);
    }
}
