using SAGOM.Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace SAGOM.WebAPI.Models
{
    public class PessoaModel
    {
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Celular { get; private set; }
        public string Endereco { get; private set; }
        public PersonDTO DTO { get; private set; }

        public PessoaModel(string cpf)
        {
            Cpf = cpf;
        }

        public PessoaModel(PersonDTO dto)
        {
            Cpf = dto.Cpf;
            Email = dto.Email;
            NomeCompleto = dto.Name.Trim() + " " + dto.LastName;
            Celular = dto.CellPhone;
            Endereco = dto.Address;
            DTO = dto;
        }
    }
}
