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
    public partial class Form1 : Form
    {
        private List<Carta> cartaList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // comboBoxTipoCarta.Items.Add("Selccionar");
            LoadFile();
            UpdateComboBox();
            UpdateDataGView();
          
        }

        private void UpdateDataGView()
        {
          
            dataGViewInfoCartas.DataSource = cartaList;

        }

        private void UpdateComboBox()
        {
            comboBoxCarta.DataSource = cartaList;
            comboBoxCarta.DisplayMember = "Nombre";
            comboBoxCarta.ValueMember = "CartaId";

            var query = cartaList.Select(x => x.TipoCarta).Distinct().ToList();
            comboBoxTipoCarta.DataSource = query;
            comboBoxTipoCarta.DisplayMember = "TipoCarta";
        }

        private void LoadFile()
        {
            StreamReader sr = new StreamReader("cartas.json");
            string json = sr.ReadToEnd();
            cartaList = JsonConvert.DeserializeObject<List<Carta>>(json);

        }

        private void comboBoxTipoCarta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxTipoCarta.Text == "Comun"
            if (comboBoxTipoCarta.SelectedIndex > 0)
            {
                List<Carta> comun = cartaList.Where(x => x.TipoCarta == (string)comboBoxTipoCarta.SelectedValue).ToList();
                dataGViewInfoCartas.DataSource = comun;
            }
            else
            {
                dataGViewInfoCartas.DataSource = cartaList;
            }
      
        }

        private void comboBoxCarta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           pictureBoxCarta.ImageLocation = "img/" + cartaList[comboBoxCarta.SelectedIndex].Imagen;

        }

        private void btCartasMayores_Click(object sender, EventArgs e)
        {
            //Mayor a menor para el GridView

            List<Carta> Descendente = cartaList.OrderByDescending(o => o.CostoElixer).ToList();
            dataGViewInfoCartas.DataSource = Descendente;
            //  comboBoxCarta.DataSource = Descendente;
             // pictureBoxCarta.ImageLocation = "img/" + cartaList[comboBoxCarta.SelectedIndex].Imagen;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            new TipodeCarta().Show();
        }
    }
}
