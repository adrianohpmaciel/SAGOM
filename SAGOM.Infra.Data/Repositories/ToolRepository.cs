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
    public class ToolRepository : IToolRepository
    {
        SagomDbContext _db;

        public ToolRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Tool> CreateAsync(Tool tool)
        {
            _db.Add(tool);
            await _db.SaveChangesAsync();
            return tool;
        }

        public async Task<Tool> GetToolByIdAsync(int idTool)
        {
            return await _db.Tools.FindAsync(idTool);
        }

        public async Task<IEnumerable<Tool>?> GetToolsByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Tools.Where(p => p.Name.ToLower()
                                                      .StartsWith(name)
                                                      ).ToListAsync();
        }

        public async Task<Tool> RemoveAsync(Tool tool)
        {
            _db.Remove(tool);
            await _db.SaveChangesAsync();
            return tool;
        }

        public async Task<Tool> UpdateAsync(Tool tool)
        {
            _db.Update(tool);
            await _db.SaveChangesAsync();
            return tool;
        }
    }
}
