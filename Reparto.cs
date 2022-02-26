using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaVerifica
{
    class Reparto
    {
        public string NomeReparto { get; set; }
        public List<Dipendente> Dipendenti { get; }

        public Reparto(string nome)
        {
            NomeReparto = nome;
            Dipendenti = new List<Dipendente>();
        }
    }
}
