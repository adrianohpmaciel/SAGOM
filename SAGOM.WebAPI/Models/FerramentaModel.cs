using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class FerramentaModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Descricao { get; private set; }
        public decimal? Valor { get; private set; }
        public DateTime? DataDeCompra { get; private set; }
        public DateTime? DataDeDescarte { get; private set; }
        public string Status { get; private set; }
        public ColaboradorModel Responsavel { get; private set; }
        public ToolDTO DTO { get; private set; }

        public FerramentaModel(ToolDTO tool, EmployeeDTO responsavel)
        {
            Id = tool.Id;
            Nome = tool.Name;
            Descricao = tool.Description;
            Valor = tool.Price;
            DataDeCompra = tool.PurchaseDate;
            DataDeDescarte = tool.DiscardDate ;
            Status = tool.Status;
            Responsavel = new ColaboradorModel(responsavel);
            DTO = tool;
        }

        public void RegistrarDescarte()
        {
            DataDeDescarte = DateTime.UtcNow;
        }
    }
}
