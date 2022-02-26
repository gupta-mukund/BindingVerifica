using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace GuptaVerifica
{
    public partial class Form2 : Form
    {
        private List<Reparto> reparti;
        private Form1 prevForm;
        public Form2(Form1 form)
        {
            InitializeComponent();
            prevForm = form;
            reparti = new List<Reparto>();
            AddItemsToList(ref reparti);
            BindForm(ref reparti);
        }

        private void AddItemsToList(ref List<Reparto> lista)
        {
            lista.Add(new Reparto("Commerciale"));
            lista[0].Dipendenti.Add(new Dipendente("A000", "Mario Franco", "10k"));
            lista[0].Dipendenti.Add(new Dipendente("A001", "Quirino Mirta ", "15k"));
            lista[0].Dipendenti.Add(new Dipendente("A002", "Silvio Giancarlo", "5k"));
            lista.Add(new Reparto("Ricerca e sviluppo"));
            lista[1].Dipendenti.Add(new Dipendente("A003", "Pasqualina Sofia", "20k"));
            lista[1].Dipendenti.Add(new Dipendente("A004", "Patrizio Gioele", "60k"));
            lista[1].Dipendenti.Add(new Dipendente("A005", "Gioconda Isotta", "40k"));
            lista.Add(new Reparto("Logistico"));
            lista[2].Dipendenti.Add(new Dipendente("A006", "Vilfredo Rosalinda", "12k"));
            lista[2].Dipendenti.Add(new Dipendente("A007", "Ciro Eustorgio", "24k"));
            lista[2].Dipendenti.Add(new Dipendente("A008", "Glauco Vincente", "8k"));
            lista.Add(new Reparto("Risorse umane"));
            lista[3].Dipendenti.Add(new Dipendente("A009", "Placido Gallo", "8k"));
            lista[3].Dipendenti.Add(new Dipendente("A0010", "Annibale Norma", "26k"));
            lista[3].Dipendenti.Add(new Dipendente("A0011", "Alvise Rolando", "32k"));
        }
        private void BindForm(ref List<Reparto> lista)
        {
            BindingSource data = new BindingSource();
            data.DataSource = lista;

            cmbReparto.DataSource = data;
            cmbReparto.DisplayMember = "NomeReparto";
            lsbDipendenti.DataSource = data;
            lsbDipendenti.DisplayMember = "Dipendenti.Matricola";
            txtNome.DataBindings.Add(new Binding("Text", data, "Dipendenti.Nome"));
            txtRetribuzione.DataBindings.Add(new Binding("Text", data, "Dipendenti.Retribuzione"));
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            prevForm.Dispose();
            this.Dispose();
        }
    }
}
