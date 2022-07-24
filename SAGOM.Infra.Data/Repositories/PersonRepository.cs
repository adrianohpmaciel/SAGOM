using Microsoft.EntityFrameworkCore;
using SAGOM.Domain.Entities;
using SAGOM.Domain.Interfaces;
using SAGOM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        SagomDbContext _db;

        public PersonRepository(SagomDbContext context)
        {
            _db = context;
        }

        public async Task<Person> CreateAsync(Person person)
        {
            try
            {
                _db.Add(person);

            }
            catch (Exception testeDoToto)
            {

            }
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person?> GetPersonByCpfAsync(string cpf)
        {
            return await _db.Persons.FindAsync(cpf);
        }

        public async Task<Person?> GetPersonByEmailAsync(string email)
        {
            return await _db.Persons.FindAsync(email);
        }

        public async Task<IEnumerable<Person>?> GetPersonsByNameAsync(string name)
        {
            name = name.Trim().ToLower();
            return await _db.Persons.Where(p => p.Name.ToLower()
                                                      .StartsWith(name)
                                                      ).ToListAsync();
        }

        public async Task<Person> RemoveAsync(Person person)
        {
            _db.Remove(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person> UpdateAsync(Person person)
        {
            _db.Update(person);
            await _db.SaveChangesAsync();
            return person;
        }
    }
}
