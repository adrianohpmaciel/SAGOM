namespace SAGOM.WebAPI.Models
{
    public class ColaboradorModel
    {
        public int Id { get; private set; }
        public CargoModel Cargo { get; private set; }
        public PessoaModel Pessoa { get; private set; }
        public double Salario { get; private set; }

        public ColaboradorModel(int id, CargoModel cargo, PessoaModel pessoa, double salario)
        {
            Id = id;
            Cargo = cargo;
            Pessoa = pessoa;
            Salario = salario;
        }

    }
}
