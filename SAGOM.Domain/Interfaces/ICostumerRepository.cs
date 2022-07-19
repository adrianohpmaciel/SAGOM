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
        Task<IEnumerable<Costumer>> GetCostumersAsync();
        Task<IEnumerable<Costumer>> GetCostumersByNameAsync(string name);
        Task<IEnumerable<Costumer>> GetCostumerByIdAsync(int id);
        Task<IEnumerable<Costumer>> GetCostumerByCPFAsync(string cpf);
        Task<IEnumerable<Costumer>> CreateAsync(Costumer costumer);
        Task<IEnumerable<Costumer>> UpdateAsync(Costumer costumer);
        Task<IEnumerable<Costumer>> RemoveAsync(Costumer costumer);
    }
}
