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
        Task<IEnumerable<Person>?> GetPersonsByNameAsync(string name);
        Task<Person?> GetPersonByCPFAsync(string cpf);
        Task<Person> CreateAsync(Person person);
        Task<Person?> UpdateAsync(Person person);
        Task<Person?> RemoveAsync(Person person);
    }
}
