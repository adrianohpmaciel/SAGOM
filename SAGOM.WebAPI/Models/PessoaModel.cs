using System.ComponentModel.DataAnnotations;

namespace SAGOM.WebAPI.Models
{
    public class PessoaModel
    {
        public string Cpf { get; private set; }
        [Required]
        [EmailAddress]
        public string Email { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Celular { get; private set; }
        public string Endereco { get; private set; }

        public PessoaModel(string cpf, string email, string nomeCompleto, string celular, string endereco)
        {
            Cpf = cpf;
            Email = email;
            NomeCompleto = nomeCompleto;
            Celular = celular;
            Endereco = endereco;
        }
    }
}
