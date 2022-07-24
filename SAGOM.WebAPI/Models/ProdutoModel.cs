using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class ProdutoModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal? ValorUnidade { get; private set; }
        public ProductDTO DTO { get; private set; }

        public ProdutoModel(ProductDTO dto)
        {
            Id = dto.Id;
            Nome = dto.Name;
            Descricao = dto.Description;
            Quantidade = dto.Quantity;
            ValorUnidade = dto.UnitPrice;
            DTO = dto;
        }

    }
}
