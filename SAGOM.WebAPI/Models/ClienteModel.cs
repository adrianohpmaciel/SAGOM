using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class ClienteModel
    {
        public int? Id { get; private set; } = null;
        public PessoaModel Pessoa { get; private set; }
        public List<VeiculoModel>? Veiculos { get; private set; } = null;

        public ClienteModel(PersonDTO pessoa)
        {
            Pessoa = new PessoaModel(pessoa);
        }

        public void AddVeiculo(VeiculoModel veiculo)
        {
            if (Veiculos == null)
                Veiculos = new List<VeiculoModel>();

            Veiculos.Add(veiculo);
        }
    }
}
