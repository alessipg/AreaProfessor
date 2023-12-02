using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProfessor
{
    public class Pontuacao
    {
        public Pontuacao() { }
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Fase1 { get; set; }
        public int Fase2 { get; set; }
        public string Data { get; set; }
        public string Tempo { get; set; }
        public string Total { get; set; }
        public string Obs { get; set; }
    }
}
