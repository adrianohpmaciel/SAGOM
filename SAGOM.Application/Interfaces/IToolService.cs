using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface IToolService
    {
        Task<IEnumerable<ToolDTO>> GetToolsByName(string name);
        Task<ToolDTO> GetToolById(int idTool);
        Task Add(ToolDTO tool);
        Task Update(ToolDTO tool);
        Task Remove(ToolDTO tool);
    }
}