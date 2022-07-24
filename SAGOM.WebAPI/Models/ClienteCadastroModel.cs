using SAGOM.Application.DTOs;
using System.ComponentModel.DataAnnotations;

namespace SAGOM.WebAPI.Models
{
    public class ClienteCadastroModel
    {
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public string Celular { get; private set; }
        public string Endereco { get; private set; }
        public string Password { get; set; }

        public ClienteCadastroModel(string cpf, string email, string nome, string sobrenome, string celular, string endereco, string password)
        {
            Cpf = cpf;
            Email = email;
            Nome = nome;
            SobreNome = sobrenome;
            Celular = celular;
            Endereco = endereco;
            Password = password;
        }
    }
}
