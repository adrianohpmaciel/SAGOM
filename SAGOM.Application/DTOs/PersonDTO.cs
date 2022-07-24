using SAGOM.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class PersonDTO
    {
        public string Cpf { get; private set; } = null!;
        public string Email { get; private set; } = null!;
        public string Name { get; private set; } = null!;
        public string LastName { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public string CellPhone { get; private set; } = null!;

        public PersonDTO(string cpf, string email, string name, string lastName, string address, string cellPhone)
        {
            Cpf = cpf;
            Email = email;
            Name = name;
            LastName = lastName;
            Address = address;
            CellPhone = cellPhone;
        }
    }

}
