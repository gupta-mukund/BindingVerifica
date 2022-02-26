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
    public partial class Form1 : Form
    {
        private List<Azienda> aziende;
        public Form1()
        {
            InitializeComponent();
            aziende = new List<Azienda>();
            AddItemsToList(ref aziende);
            BindForm(ref aziende);
            CreateJson(ref aziende);
        }
        private void AddItemsToList(ref List<Azienda> lista)
        {
            //adding data
            lista.Add(new Azienda("La Vigna Srl", "Via Roma 12, Padova", "00146274525", "Luigi Lovato"));
            lista.Add(new Azienda("Fergros", "Corso Garibaldi, Mestre", "00485916478", "Alessandro Pala"));
            lista.Add(new Azienda("FNP Progettazione", "Via Castello 8, Venezia", "00417951368", "Marco Fornasa"));
            lista.Add(new Azienda("Protein Ice Cream", "Via Trissino, 25, Firenze", "00254976388", "Pietro Bruttomesso"));
            lista.Add(new Azienda("Bakery", "Via Alfieri, 23, Genova", "00687513095", "Luigi Matteotti"));
        }
        private void BindForm(ref List<Azienda> lista)
        { 
            //oggetto per bindare la lista
            BindingSource bind = new BindingSource();
            bind.DataSource = lista;

            //bind del nome azienda su combobox
            cmbAzienda.DataSource = bind;
            cmbAzienda.DisplayMember = "Nome";

            //bind delle textbox con classe Binding
            txtPresidente.DataBindings.Add(new Binding("Text", bind, "Presidente"));
            txtIndirizzo.DataBindings.Add(new Binding("Text", bind, "IndirizzoCompleto"));

            txtCognomeBind.DataBindings.Add(new Binding("Text", txtCognome, "Text"));
            txtCognome.DataBindings.Add(new Binding("Text", txtCognomeBind, "Text"));
        }
        private void CreateJson(ref List<Azienda> lista)
        {
            //creazione json e salvamento in file
            string output = JsonConvert.SerializeObject(lista, Formatting.Indented);
            txtJson.Text = output;

            File.WriteAllText(Directory.GetCurrentDirectory() + @"/data.json", output);

        }
        private void txtNext_Click(object sender, EventArgs e)
        {
            //prossimo esercizio
            Hide();
            new Form2(this).Show();
        }
    }
}
