using Microsoft.EntityFrameworkCore;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        SagomDbContext _db;

        public VehicleRepository(SagomDbContext db)
        {
            _db = db;
        }

        public async Task<Vehicle?> Create(Vehicle vehicle)
        {
            _db.Add(vehicle);
            await _db.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle?> GetVehicleById(int id)
        {
            return await _db.Vehicles.FindAsync(id);
        }

        public async Task<Vehicle?> GetVehicleByLicensePlateAndCountry(string licensePlate, string country)
        {
            return await _db.Vehicles.FindAsync(licensePlate, country);
        }

        public async Task<IEnumerable<Vehicle>> GetVehiclesByCostumer(Costumer costumer)
        {
            return await _db.Vehicles.Where(v => v.IdCostumerNavigation.Equals(costumer)).ToListAsync();
        }

        public async Task<Vehicle?> Remove(Vehicle vehicle)
        {
            _db.Remove(vehicle);
            await _db.SaveChangesAsync();
            return vehicle;
        }

        public async Task<Vehicle?> Update(Vehicle vehicle)
        {
            _db.Update(vehicle);
            await _db.SaveChangesAsync();
            return vehicle;
        }
    }
}
