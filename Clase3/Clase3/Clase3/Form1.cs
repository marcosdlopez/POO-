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
        Zoologico zoo = new Zoologico();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add(zoo.Carnivoro);
            comboBox1.Items.Add(zoo.Herbivoro);

            comboBox1.DisplayMember = "Tipo";

            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Nombre = textBox1.Text;
            animal.Alimentacion = (Alimentacion)comboBox1.SelectedItem;

            zoo.Agregar(animal);

            Enlazar();
        }

        void Enlazar()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = zoo.Animales;

            comboBox2.DataSource = null;
            comboBox2.DataSource = zoo.Animales;
            comboBox2.DisplayMember = "nombre";
            listBox1.DisplayMember = "nombre";

            List<Animal> tmp = zoo.Animales.ToArray().ToList<Animal>();
            comboBox3.DataSource = null;
            comboBox3.DataSource = tmp;
            comboBox3.DisplayMember = "nombre";

            label3.Text = "Cantidad de animales: " + zoo.Animales.Count.ToString();

            listBox2.DataSource = null;
            listBox2.DataSource = zoo.DevolverPorTipo(zoo.Carnivoro);
            listBox2.DisplayMember = "nombre";

            listBox3.DataSource = null;
            listBox3.DataSource = zoo.DevolverPorTipo(zoo.Herbivoro);
            listBox3.DisplayMember = "nombre";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = zoo.Animales;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal anim = (Animal)comboBox3.SelectedItem;

            zoo.Quitar(anim);

            Enlazar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Animal item in listBox1.SelectedItems)
            {
                zoo.Quitar(item);

            }
            Enlazar();

        }
    }
}
