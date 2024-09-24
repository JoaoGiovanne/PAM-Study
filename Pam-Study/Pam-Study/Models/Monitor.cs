using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pam_Study.Models
{
    public class Monitor
    {
        public long IdMonitor { get; set; }
        public string Nome {  get; set; }
        public string Foto { get; set; }
        public string Whatszapp { get; set; }
        public string Email { get; set; }
        public string Conteudo { get; set; }
        public Disciplina id { get; set; }
        public List<Disponibilidade> Disponibilidades { get; set; }
    }
}
