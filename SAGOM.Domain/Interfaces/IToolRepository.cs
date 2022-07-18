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
        Task<IEnumerable<Tool>> GetToolsAsync();
        Task<IEnumerable<Tool>> GetToolsByNameAsync(string name);
        Task<IEnumerable<Tool>> GetToolByIdAsync(int idTool);
        Task<IEnumerable<Tool>> CreateAsync(Tool tool);
        Task<IEnumerable<Tool>> UpdateAsync(Tool tool);
        Task<IEnumerable<Tool>> RemoveAsync(Tool tool);
    }
}