using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoHoras3.Data
{
    public class Lancamento
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int idProjeto { get; set; }

        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
    }
}
