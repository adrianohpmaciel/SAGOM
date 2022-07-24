using SAGOM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    public class CostumerDTO
    {
        public int Id { get; private set; }
        public string? Cpf { get; private set; }
        public PersonDTO? CpfNavigation { get; set; }

        public CostumerDTO( string? cpf, PersonDTO person = null) 
        { 
            Cpf = cpf;
            CpfNavigation = person;
        }
    }
}
