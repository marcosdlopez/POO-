using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase3
{
    public partial class Form1 : Form
    {

        Curso curso = new Curso();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(dateTimePicker1.Value);
            p.Nombre =textBox1.Text;

            p.Sexo = (radioButton1.Checked) ? "Masculino" : "Femenino";

            curso.Personas.Add(p);
            Enlazar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(dateTimePicker1.Value,textBox1.Text );
       
            listBox1.Items.Add(p);
            p.Sexo = (radioButton1.Checked) ? "Masculino" : "Femenino";
            curso.Personas.Add(p);
            Enlazar();
        }

        public void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = curso.Personas;
            listBox1.DisplayMember = "Etiqueta";

            comboBox1.DataSource = null;
            comboBox1.DataSource = curso.Personas;
            comboBox1.DisplayMember = "Etiqueta";

            comboBox2.DataSource = null;
            comboBox2.DataSource = curso.Personas.ToArray().ToList<Persona>(); 
            comboBox2.DisplayMember = "Etiqueta";


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = curso.Personas;

        }
    }
}
