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
            role = _db.Roles.Add(role).Entity;
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

        public async Task<bool> RemoveByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            IEnumerable<Role> roles = await _db.Roles.Where(p => p.Name.ToLower().StartsWith(name)).ToListAsync();

            foreach (Role role in roles)
            {
                _db.Roles.Remove(role);
                await _db.SaveChangesAsync();
            }

            return true;
        }

        public async Task<Role> RemoveAsync(Role role)
        {
            var roleSelected = await _db.Roles.FindAsync(role.Id);

            if (roleSelected != null)
            {
                _db.Roles.Remove(roleSelected);
                await _db.SaveChangesAsync();
            }

            return roleSelected;
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            var roleSelected = await _db.Roles.FindAsync(role.Id);


            if (roleSelected != null)
            {
                roleSelected.Name = role.Name;
                roleSelected.Description = role.Description;
                _db.Update(roleSelected);                
                await _db.SaveChangesAsync();
            }

            return roleSelected?? role;
        }
    }
}
