using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class ColaboradorModel
    {
        public int? Id { get; private set; }
        public CargoModel Cargo { get; private set; }
        public PessoaModel Pessoa { get; private set; }
        public decimal? Salario { get; private set; }
        public EmployeeDTO DTO { get; private set; }

        public ColaboradorModel(EmployeeDTO dto)
        {
            Id = dto.Id;
            Cargo = new CargoModel(dto.IdRole);
            Pessoa = new PessoaModel(dto.Cpf);
            Salario = dto.Salary;
        }

    }
}
