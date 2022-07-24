namespace SAGOM.WebAPI.Models
{
    public class VeiculoModel
    {
        public int Id { get; private set; }
        public DateTime dataCadastro { get; private set; }
        public string Placa { get; private set; }
        public string Paihs { get; private set; }
        public string Estado { get; private set; }
        public int Ano { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set;  }

        public VeiculoModel(int id, DateTime dataCadastro, string placa, string paihs, string estado, int ano, string marca, string modelo)
        {
            Id = id;
            this.dataCadastro = dataCadastro;
            Placa = placa;
            Paihs = paihs;
            Estado = estado;
            Ano = ano;
            Marca = marca;
            Modelo = modelo;
        }
    }
}
