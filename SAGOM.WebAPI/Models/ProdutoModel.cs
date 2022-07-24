namespace SAGOM.WebAPI.Models
{
    public class ProdutoModel
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public double ValoUnidade { get; private set; }

        public ProdutoModel(int id, string nome, string descricao, int quantidade, double valoUnidade)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            ValoUnidade = valoUnidade;
        }
    }
}
