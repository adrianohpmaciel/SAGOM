using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class ServicoModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Descricao { get; private set; }
        public decimal? Valor { get; private set; }
        public ServiceDTO DTO { get; private set; }

        public ServicoModel(ServiceDTO dto)
        {
            Id = dto.Id;
            Nome = dto.Name;
            Descricao = dto.Description;
            Valor = dto.Price;
            DTO = dto;
        }
    }
}
