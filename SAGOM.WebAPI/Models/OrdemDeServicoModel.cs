namespace SAGOM.WebAPI.Models
{
    public class OrdemDeServicoModel
    {
        public int Id { get; private set; }
        public string Motivo { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataUltimaAtualizacaoStatus { get; private set; }
        public List<ProdutoModel> Produtos { get; private set; }
        public List<ServicoModel> Servicos { get; private set; }
        public double ValorTotal { get; private set; }
        public string Status { get; private set; }

        public OrdemDeServicoModel(int id, string motivo, DateTime data, DateTime dataUltimaAtualizacaoStatus, List<ProdutoModel> produtos, List<ServicoModel> servicos, double valorTotal, string status)
        {
            Id = id;
            Motivo = motivo;
            Data = data;
            DataUltimaAtualizacaoStatus = dataUltimaAtualizacaoStatus;
            Servicos = servicos;
            Produtos = produtos;
            ValorTotal = valorTotal;
            Status = status;
        }

        public void Aprovar()
        {
            Status = "aprovado";
            DataUltimaAtualizacaoStatus = DateTime.UtcNow;
        }


        public void Cancelar()
        {
            Status = "cancelado";
            DataUltimaAtualizacaoStatus = DateTime.UtcNow;
        }

        public void AdicionarProduto(ProdutoModel produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(ProdutoModel produto)
        {
            Produtos.Remove(produto);
        }

        public void AdicionarServico(ServicoModel servico)
        {
            Servicos.Add(servico);
        }

        public void RemoverServico(ServicoModel servico)
        {
            Servicos.Remove(servico);
        }

    }
}
