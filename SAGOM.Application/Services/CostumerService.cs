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
    public class CostumerService : ICostumerService
    {
        private ICostumerRepository _costumerRepository;
        private readonly IMapper _mapper;

        public CostumerService(ICostumerRepository costumerRepository, IMapper mapper)
        {
            _costumerRepository = costumerRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CostumerDTO>?> GetCostumersByName(string name)
        {
            var costumersEntity = await _costumerRepository.GetCostumersByNameAsync(name);
            return _mapper.Map<IEnumerable<CostumerDTO>>(costumersEntity);
        }

        public async Task<CostumerDTO?> GetCostumerByCpf(string cpf)
        {
            var costumerEntity = await _costumerRepository.GetCostumerByCpfAsync(cpf);
            return _mapper.Map<CostumerDTO>(costumerEntity);
        }

        public async Task<CostumerDTO?> GetCostumerById(int id)
        {
            var costumerEntity = await _costumerRepository.GetCostumerByIdAsync(id);
            return _mapper.Map<CostumerDTO>(costumerEntity);
        }

        public async Task Add(CostumerDTO costumer)
        {
            var costumerEntity = _mapper.Map<Costumer>(costumer);
            await _costumerRepository.CreateAsync(costumerEntity);
        }

        public async Task Update(CostumerDTO costumer)
        {
            var costumerEntity = _mapper.Map<Costumer>(costumer);
            await _costumerRepository.UpdateAsync(costumerEntity);
        }

        public async Task Remove(CostumerDTO costumer)
        {
            var costumerEntity = _mapper.Map<Costumer>(costumer);
            await _costumerRepository.RemoveAsync(costumerEntity);
        }
    }
}
