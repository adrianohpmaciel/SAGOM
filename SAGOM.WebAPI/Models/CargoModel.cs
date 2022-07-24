using SAGOM.Application.DTOs;
using System.ComponentModel;

namespace SAGOM.WebAPI.Models
{
    [DisplayName("Cargo")]
    public class CargoModel
    {
        public int? Id { get; private set; }
        public string Nome { get; private set; }
        public string? Descricao { get; private set; }
        public RoleDTO DTO { get; private set; }

        public CargoModel(RoleDTO role)
        {
            DTO = role;
            Id = role.Id; 
            Nome = role.Name;
            Descricao = role.Description;
        }
    }
}
