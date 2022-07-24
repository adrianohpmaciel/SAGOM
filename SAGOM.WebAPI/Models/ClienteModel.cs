namespace SAGOM.WebAPI.Models
{
    public class ClienteModel
    {
        public int Id { get; private set; }
        public PessoaModel Pessoa { get; private set; }
        public VeiculoModel[] Veiculos { get; private set; }

        public ClienteModel(int id, PessoaModel pessoa, VeiculoModel[] veiculos)
        {
            Id = id;
            Pessoa = pessoa;
            Veiculos = veiculos;
        }
    }
}
