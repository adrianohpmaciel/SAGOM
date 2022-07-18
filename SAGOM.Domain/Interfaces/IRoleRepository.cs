using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetRolesAsync();
        Task<IEnumerable<Role>> GetRolesByNameAsync(string name);
        Task<IEnumerable<Role>> GetRoleByIdAsync(string idRole);
        Task<IEnumerable<Role>> CreateAsync(Role role);
        Task<IEnumerable<Role>> UpdateAsync(Role role);
        Task<IEnumerable<Role>> RemoveAsync(Role role);
    }
}
