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
    public class ServiceOrderService : IServiceOrderService
    {
        private IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;

        public ServiceOrderService(IServiceOrderRepository serviceOrderRepository, IMapper mapper)
        {
            _serviceOrderRepository = serviceOrderRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ServiceOrderDTO>?> GetServiceOrdersByCostumerService(CostumerServiceDTO costumerService)
        {
            var costumerServiceEntity = _mapper.Map<Domain.Entities.CostumerService>(costumerService);
            var serviceOrdersEntities = _serviceOrderRepository.GetServiceOrdersByCostumerServiceAsync(costumerServiceEntity);
            return _mapper.Map<IEnumerable<ServiceOrderDTO>>(costumerServiceEntity);
        }

        public async Task<ServiceOrderDTO?> GetServiceOrderById(int id)
        {
            var serviceOrderEntity = await _serviceOrderRepository.GetServiceOrderByIdAsync(id);
            return _mapper.Map<ServiceOrderDTO>(serviceOrderEntity);
        }

        public async Task Add(ServiceOrderDTO serviceOrder)
        {
            var serviceOrderEntity = _mapper.Map<ServiceOrder>(serviceOrder);
            await _serviceOrderRepository.CreateAsync(serviceOrderEntity);
        }

        public async Task Update(ServiceOrderDTO serviceOrder)
        {
            var serviceOrderEntity = _mapper.Map<ServiceOrder>(serviceOrder);
            await _serviceOrderRepository.UpdateAsync(serviceOrderEntity);
        }

        public async Task Remove(ServiceOrderDTO serviceOrder)
        {
            var serviceOrderEntity = _mapper.Map<ServiceOrder>(serviceOrder);
            await _serviceOrderRepository.RemoveAsync(serviceOrderEntity);
        }
    }
}
