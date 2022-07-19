using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IVehicleService
    { 
        Task<IEnumerable<VehicleDTO>> GetVehiclesByCostumer(CostumerDTO costumer);
        Task<VehicleDTO?> GetVehicleByLicensePlateAndCountry(string licensePlate, string country);
        Task<VehicleDTO?> GetVehicleById(int id);
        Task Add(VehicleDTO vehicle);
        Task Update(VehicleDTO vehicle);
        Task Remove(VehicleDTO vehicle);
    }
}
