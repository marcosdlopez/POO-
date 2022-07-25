using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        Televisor tv;

        ControlRemoto cr = new ControlRemoto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Complete los campos");
                txtMarca.Focus();
            }
            else
            {
                Televisor tele = new Televisor();
                tele = new Televisor();
                tele.Marca = txtMarca.Text;
                tele.Color = txtColor.Text;

                lstTelevisores.Items.Add(tele);

            }    

        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if(tv != null)
            { 
                tv.Encender();
            }
            else
            {
                MostrarError();
            }

        }

        void MostrarError()
        {
            MessageBox.Show("Te faltó el new","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tv != null)
            {
               if( !tv.SubirCanal())
                {
                    MessageBox.Show("Prendé la tele");
                }
                Consultar();
            }
            else
            {
                MostrarError();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tv != null)
            {
                if (!tv.BajarCanal())
                {
                    MessageBox.Show("Prendé la tele");
                   
                }
                Consultar();
            }
            else
            {
                MostrarError();
            }
        }

        private void lstTelevisores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstTelevisores.SelectedItem != null)
            {
                tv = (Televisor)lstTelevisores.SelectedItem;
                Consultar();
            }

        }

        void Consultar()
        {
            if (tv != null)
            {
                lblResultado.Text = tv.Marca + " " + tv.encendido.ToString() + " Canal: " + tv.canalactual.ToString();
            }
            else
            {
                MostrarError();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tv != null)
            {
                cr.Encender(tv);
                Consultar();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (tv != null)
            {
                cr.SubirCanal(tv);
                Consultar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tv != null)
            {
                cr.Bajar(tv);
                Consultar();
            }
        }
    }
}
