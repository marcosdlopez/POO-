using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {

        AireAcondicionado aire;

        ControlRemoto cr = new ControlRemoto();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AireAcondicionado aireTmp;
            aireTmp = new AireAcondicionado();
            aireTmp.Marca = txtMarca.Text;
            aireTmp.Color = txtColor.Text;
            aireTmp.Frigorias = int.Parse(txtFrigorias.Text);

            lstAires.Items.Add(aireTmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        void Consultar()
        {
            if (aire != null)
            {
                lblResultado.Text = aire.Marca + " Encendido: " + aire.Encendido.ToString() + " Temp: " + aire.Temperatura.ToString() + "º";
            }
            else
            {
                MostrarError();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (aire != null)
            {
                aire.Encender();
                Consultar();
            }
            else
            {
                MostrarError();
            }    
        }


        void MostrarError()
        {
            MessageBox.Show("Te falta instanciar!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lstAires_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAires.SelectedItem != null && lstAires.SelectedItem is AireAcondicionado )
            {
                aire = (AireAcondicionado)lstAires.SelectedItem;
                Consultar();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TELEVISION tv = new TELEVISION();
            tv.Marca = "SAnyo";
            lstAires.Items.Add(tv);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (aire != null)
            {
                cr.Encender(aire);
                Consultar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (aire != null)
            {
                cr.Subir(aire);
                Consultar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (aire != null)
            {
                cr.Bajar(aire);
                Consultar();
            }
        }
    }
}
