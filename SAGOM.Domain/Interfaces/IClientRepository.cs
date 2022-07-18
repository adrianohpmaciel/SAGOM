using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<IEnumerable<Client>> GetClientsByNameAsync(string name);
        Task<IEnumerable<Client>> GetClientByIdAsync(int id);
        Task<IEnumerable<Client>> GetClientByCPFAsync(string cpf);
        Task<IEnumerable<Client>> CreateAsync(Client client);
        Task<IEnumerable<Client>> UpdateAsync(Client client);
        Task<IEnumerable<Client>> RemoveAsync(Client client);
    }
}
