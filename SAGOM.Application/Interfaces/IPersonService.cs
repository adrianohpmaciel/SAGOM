using SAGOM.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDTO>?> GetPersonsByName(string name);
        Task<PersonDTO?> GetPersonByCpf(string cpf);
        Task Add(PersonDTO person);
        Task Update(PersonDTO person);
        Task Remove(PersonDTO person);
    }
}
