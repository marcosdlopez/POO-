using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Operacion operacion = new Operacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sumar");
            comboBox1.Items.Add("Restar");
            comboBox1.Items.Add("Dividir");
            comboBox1.Items.Add("Multiplicar");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Sumar":
                    {
                        operacion.Calcular = Sumatoria;
                        break;
                    }
                case "Restar":
                    {
                        operacion.Calcular = Restar;
                        break;
                    }
                case "Dividir":
                    {
                        operacion.Calcular = Dividir;
                        break;
                    }
                case "Multiplicar":
                    {
                        operacion.Calcular = Multiplicar;
                        break;
                    }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion.Calcular(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }


        void Sumatoria(int num1, int otronum)
        {
            label1.Text = (num1 + otronum).ToString();

        }

      void Restar(int num1, int otronum)
        {
            label1.Text = (num1 - otronum).ToString();

        }
         void Dividir(int num1, int otronum)
        {
            label1.Text = (num1 / otronum).ToString();

        }
        void Multiplicar(int num1, int otronum)
        {
            label1.Text = (num1 * otronum).ToString();

        }
    }
}
