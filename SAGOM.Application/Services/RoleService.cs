using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces;
using SAGOM.Domain.AccountInterfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services
{
    public class RoleService : IRoleService
    {
        private IRoleRepository _roleRepository;
        private IAuthenticateRepository _authenticateRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper, IAuthenticateRepository authenticateRepository)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _authenticateRepository = authenticateRepository;
        }


        public async Task<IEnumerable<RoleDTO>> GetAllRoles()
        {
           var rolesEntities = await _roleRepository.GetAllRolesAsync();
            return _mapper.Map<IEnumerable<RoleDTO>>(rolesEntities);
        }

        public async Task<IEnumerable<RoleDTO>?> GetRolesByName(string name)
        {
            var rolesEntities = await _roleRepository.GetRolesByNameAsync(name);
            return _mapper.Map<IEnumerable<RoleDTO>>(rolesEntities);
        }

        public async Task<RoleDTO?> GetRoleById(int id)
        {
            var roleEntity = await _roleRepository.GetRoleByIdAsync(id);
            return _mapper.Map<RoleDTO>(roleEntity);
        }

        public async Task<RoleDTO> Add(RoleDTO role)
        {
            var roleEntity = _mapper.Map<Role>(role);
            await _authenticateRepository.RegisterRole(role.Name);
            
            roleEntity = await _roleRepository.CreateAsync(roleEntity);
            return _mapper.Map<RoleDTO>(roleEntity);
        }

        public async Task Update(RoleDTO role)
        {
            var roleEntity = _mapper.Map<Role>(role);
            await _roleRepository.UpdateAsync(roleEntity);
        }

        public async Task Remove(RoleDTO role)
        {
            Role roleEntity = _mapper.Map<Role>(role);
            await _authenticateRepository.RemoveRole(role.Name);
            await _roleRepository.RemoveAsync(roleEntity);
        }
        public async Task RemoveByName(string name)
        {
            await _authenticateRepository.RemoveRole(name);
            await _roleRepository.RemoveByNameAsync(name);
        }

    }
}
