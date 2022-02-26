using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuptaVerifica
{
    class Azienda
    {
        private string _partitaIva;
        public string Nome { get; set; }
        public string IndirizzoCompleto { get; set; }
        public string PartitaIva
        {
            get { return _partitaIva; }
            set
            {
                if (value.Length < 11)
                {
                    throw new Exception("Numero di caratteri insufficienti per Partita Iva");
                   
                } else
                {
                    _partitaIva = value;
                }
            }
        }
        public string Presidente { get; set; }

        public Azienda(string nome, string indirizzo, string partitaIva, string presidente)
        {
            Nome = nome;
            IndirizzoCompleto = indirizzo;
            PartitaIva = partitaIva;
            Presidente = presidente;
        }
    }
}
