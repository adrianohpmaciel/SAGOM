using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPersonsAsync();
        Task<IEnumerable<Person>> GetPersonsByNameAsync(string name);
        Task<IEnumerable<Person>> GetPersonByCPFAsync(string cpf);
        Task<IEnumerable<Person>> CreateAsync(Person person);
        Task<IEnumerable<Person>> UpdateAsync(Person person);
        Task<IEnumerable<Person>> RemoveAsync(Person person);
    }
}
