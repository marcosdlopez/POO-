using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Polideportivo
{
    public partial class frnCancha : Form
    {

        private Cancha cancha;

        public Cancha Cancha
        {
            get { return cancha; }
            set { cancha = value; }
        }

        public frnCancha()
        {
            InitializeComponent();
        }

        private void frnCancha_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(EnumTipo.tenis);
            comboBox1.Items.Add(EnumTipo.futbol5);
            comboBox1.Items.Add(EnumTipo.futbol7);
            comboBox1.Items.Add(EnumTipo.futbol11);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cancha = new Cancha();
            this.Cancha.Valor = float.Parse(textBox1.Text);
            this.cancha.Tipo = (EnumTipo)comboBox1.SelectedItem;
            this.Close();

        }
    }
}
