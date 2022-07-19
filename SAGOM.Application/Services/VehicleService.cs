using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            _vehicleRepository = vehicleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDTO>> GetVehiclesByCostumer(CostumerDTO costumer)
        {
            var costumerEntity = _mapper.Map<Costumer>(costumer);
            var vehiclesEntities = await _vehicleRepository.GetVehiclesByCostumerAsync(costumerEntity);
            return _mapper.Map<IEnumerable<VehicleDTO>>(vehiclesEntities);
        }

        public async Task<VehicleDTO?> GetVehicleByLicensePlateAndCountry(string licensePlate, string country)
        {
            var vehicleEntity = await _vehicleRepository.GetVehicleByLicensePlateAndCountryAsync(licensePlate, country);
            return _mapper.Map<VehicleDTO>(vehicleEntity);
        }

        public async Task<VehicleDTO?> GetVehicleById(int id)
        {
            var vehicleEntity = await _vehicleRepository.GetVehicleByIdAsync(id);
            return _mapper.Map<VehicleDTO>(vehicleEntity);
        }

        public async Task Add(VehicleDTO vehicle)
        {
            var vehicleEntity = _mapper.Map<Vehicle>(vehicle);
            await _vehicleRepository.CreateAsync(vehicleEntity);
        }

        public async Task Update(VehicleDTO vehicle)
        {
            var vehicleEntity = _mapper.Map<Vehicle>(vehicle);
            await _vehicleRepository.UpdateAsync(vehicleEntity);
        }

        public async Task Remove(VehicleDTO vehicle)
        {
            var vehicleEntity = _mapper.Map<Vehicle>(vehicle);
            await _vehicleRepository.RemoveAsync(vehicleEntity);
        }

    }
}
