using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data
{
    public partial class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
    }
}
