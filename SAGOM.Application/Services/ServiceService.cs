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
    public class ServiceService : IServiceService
    {
        private IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public ServiceService(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ServiceDTO>?> GetServicesByName(string name)
        {
            var servicesEntities = await _serviceRepository.GetServicesByNameAsync(name);
            return _mapper.Map<IEnumerable<ServiceDTO>>(servicesEntities);
        }

        public async Task<ServiceDTO?> GetServiceById(int id)
        {
            var serviceEntity = await _serviceRepository.GetServiceByIdAsync(id);
            return _mapper.Map<ServiceDTO>(serviceEntity);
        }

        public async Task Add(ServiceDTO service)
        {
            var serviceEntity = _mapper.Map<Service>(service);
            await _serviceRepository.CreateAsync(serviceEntity);
        }

        public async Task Update(ServiceDTO service)
        {
            var serviceEntity = _mapper.Map<Service>(service);
            await _serviceRepository.UpdateAsync(serviceEntity);
        }

        public async Task Remove(ServiceDTO service)
        {
            var serviceEntity = _mapper.Map<Service>(service);
            await _serviceRepository.RemoveAsync(serviceEntity);
        }
    }
}
