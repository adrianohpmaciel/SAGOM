using SAGOM.Application.DTOs;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace SAGOM.WebAPI.Models
{
    public class CargoModel
    {
        public int? Id { get; private set; }
        public string? Nome { get; set; }
        public string? Descricao { get;  set; }
        [JsonIgnore]
        public RoleDTO? DTO { get; private set; }

        public CargoModel()
        {

        }

        public CargoModel(int? id)
        {
            Id = id;
        }

        public CargoModel(int? id, string nome, string? descricao) : this(id)
        {
            Nome = nome;
            Descricao = descricao;
            DTO = new RoleDTO(nome, descricao);
        }

        public CargoModel(RoleDTO role)
        {
            if (role != null)
            {
                DTO = role;
                Id = role.Id;
                Nome = role.Name;
                Descricao = role.Description; 
            }

        }

        public void SetId(int id)
        {
            if (Id == null)
                Id = id;
        }
    }
}
