using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class OrdemDeServicoModel
    {
        public int Id { get; private set; }
        public string Motivo { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime? DataUltimaAtualizacaoStatus { get; private set; }
        public List<ProdutoModel>? Produtos { get; private set; } = null;
        public List<ServicoModel>? Servicos { get; private set; } = null;
        public double ValorTotal { get; private set; }
        public string Status { get; private set; }
        public ServiceOrderDTO DTO { get; private set; }

        public OrdemDeServicoModel(ServiceOrderDTO dto)
        {
            Id = dto.Id;
            Motivo = dto.Reason;
            Data = dto.Date;
            DataUltimaAtualizacaoStatus = dto.UpdateDateLastStatus;
            Status = dto.Status;
            DTO = dto;
        }

        //public OrdemDeServicoModel(int id, string motivo, DateTime data, DateTime dataUltimaAtualizacaoStatus, List<ProdutoModel> produtos, List<ServicoModel> servicos, double valorTotal, string status)
        //{
        //    Id = id;
        //    Motivo = motivo;
        //    Data = data;
        //    DataUltimaAtualizacaoStatus = dataUltimaAtualizacaoStatus;
        //    Servicos = servicos;
        //    Produtos = produtos;
        //    ValorTotal = valorTotal;
        //    Status = status;
        //}

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
            if (Produtos == null)
                Produtos = new List<ProdutoModel>();

            Produtos.Add(produto);
        }

        public void RemoverProduto(ProdutoModel produto)
        {
            if (Produtos != null && Produtos.Count > 0)
                Produtos.Remove(produto);
        }

        public void AdicionarServico(ServicoModel servico)
        {
            if (Servicos == null)
                Servicos = new List<ServicoModel>();

            Servicos.Add(servico);
        }

        public void RemoverServico(ServicoModel servico)
        {
            if (Servicos != null && Servicos.Count > 0)
                Servicos.Remove(servico);
        }

    }
}
