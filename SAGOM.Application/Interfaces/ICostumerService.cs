using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Interfaces
{
    public interface ICostumerService
    {
        Task<IEnumerable<CostumerDTO>?> GetCostumersByName(string name);
        Task<CostumerDTO?> GetCostumerById(int id);
        Task<CostumerDTO?> GetCostumerByCpf(string cpf);
        Task Add(CostumerDTO costumer);
        Task Update(CostumerDTO costumer);
        Task Remove(CostumerDTO costumer);
    }
}
