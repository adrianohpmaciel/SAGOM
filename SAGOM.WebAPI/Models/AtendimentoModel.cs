namespace SAGOM.WebAPI.Models
{
    public class AtendimentoModel
    {
        public int Id { get; private set; }
        public ClienteModel Cliente { get; private set; }
        public ColaboradorModel Colaborador { get; private set; }
        public VeiculoModel Veiculo { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime DataUltimaAlteracaoStatus { get; private set; }
        public string Descricao { get; private set; }
        public string Status { get; private set; }
        public List<OrdemDeServicoModel> OrdemDeServicoModels { get; private set; }
        public ContaModel? conta { get; private set; }
    }
}
