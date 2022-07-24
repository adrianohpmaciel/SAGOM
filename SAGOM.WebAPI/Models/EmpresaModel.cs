using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class EmpresaModel
    {
        public string Cnpj { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public CompanyDTO DTO { get; private set; }

        public EmpresaModel(CompanyDTO dto)
        {
            Cnpj = dto.Cnpj;
            Nome = dto.FantasyName;
            Endereco = dto.Address;
            Telefone = dto.Phone;
            DTO = dto;
        }
    }
}
