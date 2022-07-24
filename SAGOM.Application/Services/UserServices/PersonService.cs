using AutoMapper;
using SAGOM.Application.DTOs;
using SAGOM.Application.Interfaces.UserInterfaces;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.Services.UserServices
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PersonDTO>?> GetPersonsByName(string name)
        {
            var personsEntity = await _personRepository.GetPersonsByNameAsync(name);
            return _mapper.Map<IEnumerable<PersonDTO>>(personsEntity);
        }

        public async Task<PersonDTO?> GetPersonByEmail(string email)
        {
            var personEntity = await _personRepository.GetPersonByEmailAsync(email);
            return _mapper.Map<PersonDTO>(personEntity);
        }

        public async Task<PersonDTO?> GetPersonByCpf(string cpf)
        {
            var personEntity = await _personRepository.GetPersonByCpfAsync(cpf);
            return _mapper.Map<PersonDTO>(personEntity);
        }

        public async Task Add(PersonDTO person)
        {
            var personEntity = _mapper.Map<Person>(person);
            await _personRepository.CreateAsync(personEntity);
        }

        public async Task Update(PersonDTO person)
        {
            var personEntity = _mapper.Map<Person>(person);
            await _personRepository.UpdateAsync(personEntity);
        }

        public async Task Remove(PersonDTO person)
        {
            var personEntity = _mapper.Map<Person>(person);
            await _personRepository.RemoveAsync(personEntity);
        }
    }
}
