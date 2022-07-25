using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos2
{
    public partial class Form1 : Form
    {
        Jugador messi = new Jugador();
        public Form1()
        {
            InitializeComponent();

            messi.Festejar += Messi_Festejar;
            messi.Insultar += Messi_Insultar;

        }

        private void Messi_Insultar(string mensaje)
        {
            label1.Text += mensaje;
        }

        private void Messi_Festejar(string mensaje)
        {
            label1.Text += mensaje;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            messi.Patear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messi.Festejar += Messi_Festejar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messi.Festejar -= Messi_Festejar;
        }
    }
}
