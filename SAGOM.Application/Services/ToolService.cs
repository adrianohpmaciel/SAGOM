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
    public class ToolService : IToolService
    {
        private IToolRepository _toolRepository;
        private readonly IMapper _mapper;

        public ToolService(IToolRepository toolRepository, IMapper mapper)
        {
            _toolRepository = toolRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ToolDTO>?> GetToolsByName(string name)
        {
            var toolsEntities = await _toolRepository.GetToolsByNameAsync(name);
            return _mapper.Map<IEnumerable<ToolDTO>>(toolsEntities);
        }

        public async Task<ToolDTO?> GetToolById(int id)
        {
            var toolEntity = await _toolRepository.GetToolByIdAsync(id);
            return _mapper.Map<ToolDTO>(toolEntity);
        }

        public async Task Add(ToolDTO tool)
        {
            var toolEntity = _mapper.Map<Tool>(tool);
            await _toolRepository.CreateAsync(toolEntity);
        }

        public async Task Update(ToolDTO tool)
        {
            var toolEntity = _mapper.Map<Tool>(tool);
            await _toolRepository.UpdateAsync(toolEntity);
        }

        public async Task Remove(ToolDTO tool)
        {
            var toolEntity = _mapper.Map<Tool>(tool);
            await _toolRepository.RemoveAsync(toolEntity);
        }
    }
}
