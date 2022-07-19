using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAGOM.Domain.Entities
{
    public sealed class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Role()
        {
            Employees = new HashSet<Employee>();
        }
        public Role(int id, string name, string description)
        {
            Employees = new HashSet<Employee>();
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
