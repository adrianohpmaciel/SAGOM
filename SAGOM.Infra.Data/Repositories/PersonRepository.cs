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
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person?> GetPersonByCPFAsync(string cpf)
        {
            return await _db.Persons.FindAsync(cpf);
        }

        public async Task<IEnumerable<Person>?> GetPersonsByNameAsync(string name)
        {
            return await _db.Persons.Where(p => p.Name.ToLower()
                                                      .StartsWith(name.ToLower())
                                                      ).ToListAsync();
        }

        public async Task<Person?> RemoveAsync(Person person)
        {
            _db.Persons.Remove(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person?> UpdateAsync(Person person)
        {
            _db.Persons.Update(person);
            await _db.SaveChangesAsync();
            return person;
        }
    }
}
