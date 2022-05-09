using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Classes.Shared.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; }

        public string? Descricao { get; set; }

        public bool Concluida { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
