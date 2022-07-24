namespace SAGOM.WebAPI.Models
{
    public class ContaModel
    {
        public string Id { get; private set; }
        public PessoaModel PessoaPagante { get; private set; }
        public EmpresaModel EmpresaRecebedora { get; private set; }
        public EmpresaModel EmpresaPagante { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataVencimento  { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public string Status { get; private set; }

        public ContaModel(string id, PessoaModel pessoaPagante, EmpresaModel empresaRecebedora, EmpresaModel empresaPagante, string descricao, double valor, DateTime data, DateTime dataVencimento, DateTime dataPagamento, string status)
        {
            Id = id;
            PessoaPagante = pessoaPagante;
            EmpresaRecebedora = empresaRecebedora;
            EmpresaPagante = empresaPagante;
            Descricao = descricao;
            Valor = valor;
            Data = data;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            Status = status;
        }
    }
}
