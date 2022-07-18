using System;
using System.Collections.Generic;

namespace SAGOM.Infra.Data.EntitiesConfiguration
{
    public partial class Pessoa
    {
        public string Cpf { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public string Telefone { get; set; } = null!;

        public virtual Cliente? Cliente { get; set; }
        public virtual Colaborador? Colaborador { get; set; }
    }
}
