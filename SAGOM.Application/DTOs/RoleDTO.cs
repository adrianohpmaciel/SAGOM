using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Application.DTOs
{
    [DisplayName("Role")]
    public class RoleDTO
    {
        [Required(ErrorMessage = "Id is required")]
        public int? Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }

        public RoleDTO(string name, string? description)
        {
            Name = name;
            Description = description;
        }

        public void SetId (int id)
        {
            if (Id == null)
                Id = id;
            else
                throw new Exception("Role cannot has your id changed");
        }

    }
}