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
    public partial class frmJuez : Form
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { persona = value; }
        }


        public frmJuez()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.persona= new Persona();
            this.persona.Nombre = textBox1.Text;
            this.persona.Apellido = textBox2.Text;
            this.persona.Legajo = int.Parse(textBox3.Text);

            this.Close();
        }
    }
}
