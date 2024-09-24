using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pam_Study.Models
{
    public class Disponibilidade
    {
        public long idDisponibilidade { get; set; }
        public string DiaSemana { get; set; }
        public DateTime DtDas { get; set; }
        public DateTime DtAte { get; set; }
    }
}
