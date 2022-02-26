using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaVerifica
{
    class Dipendente
    {
        public Dipendente(string matricola, string nome, string retribuzione)
        {
            Matricola = matricola;
            Nome = nome;
            Retribuzione = retribuzione;
        }

        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Retribuzione { get; set; }


    }
}
