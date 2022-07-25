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
    public partial class Form1 : Form
    {
        SEguridad.Usuario usuario = new SEguridad.Usuario();
        Negocio.Polideportivo polideportivo = new Negocio.Polideportivo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frnCancha frm = new frnCancha();
            usuario.Usuario = "Christian";

            frm.ShowDialog();
            if (frm.Cancha != null)
            {
                polideportivo.Canchas.Add(frm.Cancha);
                comboBox1.DataSource = null;
                comboBox1.DataSource = polideportivo.Canchas;
                comboBox1.DisplayMember = "Tipo";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmJuez frm = new frmJuez();

            frm.ShowDialog();
            if (frm.Persona != null)
            {
                polideportivo.Jueces.Add(frm.Persona);
                comboBox2.DataSource = null;
                comboBox2.DataSource = polideportivo.Jueces;

                comboBox5.DataSource = null;
                comboBox5.DataSource = polideportivo.Jueces.ToArray().ToList();

                comboBox4.DataSource = null;
                comboBox4.DataSource = polideportivo.Jueces.ToArray().ToList();



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int hora = 9; hora <= 23; hora++)
            {
                comboBox3.Items.Add(hora);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                        

            Negocio.Alquiler alquiler;

            if (radioButton1.Checked)
            {
                alquiler = new Alquiler();
            }
            else if (radioButton2.Checked)
            {
                alquiler = new AlquilerArbitro();
                ((AlquilerArbitro)alquiler).Arbitro = (Persona)comboBox2.SelectedItem;

            }
            else
            {
                alquiler = new AlquilerJuezLinea();
                ((AlquilerArbitro)alquiler).Arbitro = (Persona)comboBox2.SelectedItem;
                 ((AlquilerJuezLinea)alquiler).JuezLinea1 = (Persona)comboBox2.SelectedItem;
                ((AlquilerJuezLinea)alquiler).JuezLinea2 = (Persona)comboBox2.SelectedItem;

            }

            alquiler.Cancha = (Cancha)comboBox1.SelectedItem;
            alquiler.Fecha = dateTimePicker1.Value.AddHours(int.Parse(comboBox3.Text));
            alquiler.Duracion = int.Parse(textBox1.Text);

            polideportivo.Alquilar(alquiler);

            listBox1.DataSource = null;
            listBox1.DataSource = polideportivo.Alquileres;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "Cancha + alquilada " + polideportivo.ObtenerCanchaMasAlquilada().Tipo.ToString();
            label8.Text = "Cancha + recaudacion " + polideportivo.ObtenerCanchaMasRecaudacion().Tipo.ToString();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                Cancha canchaelegida = (Cancha)comboBox1.SelectedItem;

                switch (canchaelegida.Tipo)
                {
                    case EnumTipo.tenis:
                        {
                            radioButton3.Enabled = false;
                            radioButton2.Enabled = true;
                            radioButton1.Checked = true;
                            break;
                        }
                    case EnumTipo.futbol5:
                        {
                            radioButton3.Enabled = false;
                            radioButton2.Enabled = false;
                            radioButton1.Checked = true;
                            break;
                        }
                    case EnumTipo.futbol7:
                        {
                            radioButton2.Enabled = true;
                            radioButton3.Enabled = false;
                            radioButton1.Checked = true;
                            break;
                        }
                    default:
                        {

                            radioButton2.Enabled = true;
                            radioButton3.Enabled = true;
                            break;
                        }

                }

            }
        }
    }
}
