using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IToolRepository
    {
        Task<IEnumerable<Tool>> GetToolsByNameAsync(string name);
        Task<Tool> GetToolByIdAsync(int idTool);
        Task<Tool> CreateAsync(Tool tool);
        Task<Tool> UpdateAsync(Tool tool);
        Task<Tool> RemoveAsync(Tool tool);
    }
}