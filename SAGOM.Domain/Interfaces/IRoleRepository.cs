﻿using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IRoleRepository
    {
        Task<IEnumerable<Role>> GetRolesByNameAsync(string name);
        Task<IEnumerable<Role>> GetRoleByIdAsync(int idRole);
        Task<Role> CreateAsync(Role role);
        Task<Role> UpdateAsync(Role role);
        Task<Role> RemoveAsync(Role role);
    }
}
