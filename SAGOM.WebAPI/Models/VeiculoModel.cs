using SAGOM.Application.DTOs;

namespace SAGOM.WebAPI.Models
{
    public class VeiculoModel
    {
        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Placa { get; private set; }
        public string Paihs { get; private set; }
        public string? Estado { get; private set; }
        public int? Ano { get; private set; }
        public string? Marca { get; private set; }
        public string? Modelo { get; private set;  }
        public VehicleDTO DTO { get; private set; }

        public VeiculoModel(VehicleDTO dto)
        {
            Id = dto.Id;
            Placa = dto.LicensePlate ;
            Paihs = dto.Country;
            Estado = dto.State;
            Ano = dto.Year;
            Marca = dto.BrandName;
            Modelo = dto.ModelName;
            DTO = dto;
        }


        //public VeiculoModel(int id, DateTime dataCadastro, string placa, string paihs, string estado, int ano, string marca, string modelo)
        //{
        //    DTO = null;
        //    Id = id;
        //    DataCadastro = dataCadastro;
        //    Placa = placa;
        //    Paihs = paihs;
        //    Estado = estado;
        //    Ano = ano;
        //    Marca = marca;
        //    Modelo = modelo;
        //}
    }
}
