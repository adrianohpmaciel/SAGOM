using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface ICostumerRepository
    {
        Task<IEnumerable<Costumer>?> GetCostumersByNameAsync(string name);
        Task<Costumer?> GetCostumerByIdAsync(int id);
        Task<Costumer?> GetCostumerByCPFAsync(string cpf);
        Task<Costumer> CreateAsync(Costumer costumer);
        Task<Costumer?> UpdateAsync(Costumer costumer);
        Task<Costumer?> RemoveAsync(Costumer costumer);
    }
}
