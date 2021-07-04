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

namespace Parcial01Part2
{
    public partial class TipodeCarta : Form
    {
        private List<Carta> seleccion;
        public TipodeCarta()
        {
            InitializeComponent();
            LoadFile();
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            comboBoxSeleccion.DataSource = seleccion;
            comboBoxSeleccion.DisplayMember = "Tipocarta";
            comboBoxSeleccion.ValueMember = "Tipocarta";
        }

        private void LoadFile()
        {
            StreamReader sr = new StreamReader("data (4).json");
            string json = sr.ReadToEnd();

            seleccion = JsonConvert.DeserializeObject <List< Carta >> (json);
        }


        private void TipodeCarta_Load(object sender, EventArgs e)
        {

        }


        private void comboBoxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carta query = seleccion.FirstOrDefault(x => x.TipoCarta.Equals(comboBoxSeleccion.SelectedValue.ToString()));

            if (query != null)
            {
                labelData.Text = query.Data.ToString();
                labelName.Text = query.Name.ToString();
            }
            if(comboBoxSeleccion.Text == "Comun")
            {
                Comun1.Visible = true;
                Comun2.Visible = true;
                Comun3.Visible = true;
            }
            else
            {
                Comun1.Visible = false;
                Comun2.Visible = false;
                Comun3.Visible = false;
            }
            if (comboBoxSeleccion.Text == "Especial")
            {
                Especial1.Visible = true;
                Especial2.Visible = true;
                Especial3.Visible = true;
            }
            else
            {

                Especial1.Visible = false;
                Especial2.Visible = false;
                Especial3.Visible = false;
               
            }
            if(comboBoxSeleccion.Text == "Epica")
            {
                Epica1.Visible = true;
                Epica2.Visible = true;
                Epica3.Visible = true;
            }
            else
            {
                Epica1.Visible = false;
                Epica2.Visible = false;
                Epica3.Visible = false;
            }
            if(comboBoxSeleccion.Text == "Legendario")
            {
                Legendario1.Visible = true;
                Legendario2.Visible = true;
                Legendario3.Visible = true;
            }
            else
            {
                Legendario1.Visible = false;
                Legendario2.Visible = false;
                Legendario3.Visible = false;
            }
        }

        private void Epica2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
