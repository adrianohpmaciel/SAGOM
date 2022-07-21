using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDTO>> GetAllRoles();
        Task<IEnumerable<RoleDTO>?> GetRolesByName(string name);
        Task<RoleDTO?> GetRoleById(int idRole);
        Task<RoleDTO> Add(RoleDTO role);
        Task Update(RoleDTO role);
        Task Remove(RoleDTO role);
    }
}
