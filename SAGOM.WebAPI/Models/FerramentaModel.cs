namespace SAGOM.WebAPI.Models
{
    public class FerramentaModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataDeCompra { get; private set; }
        public DateTime DataDeDescarte { get; private set; }
        public string Status { get; private set; }
        public ColaboradorModel Responsavel { get; set; }

        public FerramentaModel(int id, string nome, string descricao, double valor, DateTime dataDeCompra, DateTime dataDeDescarte, string status, ColaboradorModel responsavel)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataDeCompra = dataDeCompra;
            DataDeDescarte = dataDeDescarte;
            Status = status;
            Responsavel = responsavel;  
        }

        public void RegistrarDescarte()
        {
            DataDeDescarte = DateTime.UtcNow;
        }
    }
}
