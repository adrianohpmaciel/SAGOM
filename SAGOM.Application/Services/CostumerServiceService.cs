using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class CostumerServiceService : ICostumerServiceService
    {
        private ICostumerServiceRepository _costumerRepository;
        private readonly IMapper _mapper;

        public CostumerServiceService(ICostumerServiceRepository costumerRepository, IMapper mapper)
        {
            _costumerRepository = costumerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CostumerServiceDTO>?> GetCostumerServicesByDate(DateTime date)
        {
            var costumersEntity = await _costumerRepository.GetCostumerServicesByDateAsync(date);
            return _mapper.Map<IEnumerable<CostumerServiceDTO>>(costumersEntity);
        }

        public async Task<IEnumerable<CostumerServiceDTO>?> GetCostumerServicesByVehicle(VehicleDTO vehicle)
        {
            var vehicleEntity =  _mapper.Map<Vehicle>(vehicle);
            var costumerServicesEntities = await _costumerRepository.GetCostumerServicesByVehicleAsync(vehicleEntity);
            return _mapper.Map<IEnumerable<CostumerServiceDTO>>(costumerServicesEntities);
        }

        public async Task<CostumerServiceDTO?> GetCostumerServiceById(int id)
        {
            var costumerEntity = await _costumerRepository.GetCostumerServiceByIdAsync(id);
            return _mapper.Map<CostumerServiceDTO>(costumerEntity);
        }


        public async Task Add(CostumerServiceDTO costumer)
        {
            var costumerEntity = _mapper.Map<Domain.Entities.CostumerService>(costumer);
            await _costumerRepository.CreateAsync(costumerEntity);
        }

        public async Task Update(CostumerServiceDTO costumer)
        {
            var costumerEntity = _mapper.Map<Domain.Entities.CostumerService>(costumer);
            await _costumerRepository.UpdateAsync(costumerEntity);
        }

        public async Task Remove(CostumerServiceDTO costumer)
        {
            var costumerEntity = _mapper.Map<Domain.Entities.CostumerService>(costumer);
            await _costumerRepository.RemoveAsync(costumerEntity);
        }
    }
}
