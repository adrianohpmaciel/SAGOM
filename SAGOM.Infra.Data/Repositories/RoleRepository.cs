using Microsoft.EntityFrameworkCore;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        SagomDbContext _db;

        public RoleRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<IEnumerable<Role>> GetAllRolesAsync()
        {
            return await _db.Roles.ToListAsync();
        }

        public async Task<Role> CreateAsync(Role role)
        {
            _db.Add(role);
            await _db.SaveChangesAsync();
            return role;
        }

        public async Task<Role> GetRoleByIdAsync(int idRole)
        {
            return await _db.Roles.FindAsync(idRole);
        }

        public async Task<IEnumerable<Role>?> GetRolesByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Roles.Where(p => p.Name.ToLower()
                                                      .StartsWith(name)
                                                      ).ToListAsync();
        }

        public async Task<Role> RemoveAsync(Role role)
        {
            _db.Remove(role);
            await _db.SaveChangesAsync();
            return role;
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            _db.Update(role);
            await _db.SaveChangesAsync();
            return role;
        }
    }
}
