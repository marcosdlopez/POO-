using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLinq
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);
            AgregarPersona("Persona" , personas.Count);

            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);
            AgregarPersona("Persona", personas.Count,true);



            Enlazar();
        }

        public void AgregarPersona(string nombre, int n, bool a =false)
        {
            if (n <10 )
            {
                nombre += "0"; 
            }
            nombre += n.ToString();
            Persona p;
            if (!a)
            {
                p = new Persona(nombre, rnd.Next(20, 50));
            }
            else
            {
                p = new Alumno(nombre, rnd.Next(20, 50));
            }
            personas.Add(p);

        }

         void Enlazar( List<Persona> ps = null )
        {
            listBox1.DataSource = null;
            if (ps != null)
            {
                listBox1.DataSource = ps;
            }
            else
            { 
                listBox1.DataSource = personas;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Persona> listaTemp = ( from Persona p in personas
                                        where (string.IsNullOrWhiteSpace(textBox1.Text) || p.Edad > int.Parse(textBox1.Text))
                                        && (string.IsNullOrWhiteSpace(textBox2.Text) || p.Edad < int.Parse(textBox2.Text))
                                        orderby p.Edad descending, p.Nombre ascending
                                        select p
                                        ).ToList();

            Enlazar(listaTemp);
        }
        Persona PerEncontrada;
        private void textBox3_Leave(object sender, EventArgs e)
        {


            PerEncontrada = (from Persona p in personas
                             where p.Nombre == textBox3.Text
                             select p).FirstOrDefault();

            if(PerEncontrada !=null)
            { 
                textBox4.Text = PerEncontrada.Nombre;
                textBox5.Text = PerEncontrada.Edad.ToString();
            }
            else
            {
                textBox4.Text = String.Empty;
                textBox5.Text = String.Empty;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerEncontrada.Nombre = textBox4.Text;
            PerEncontrada.Edad= int.Parse(textBox5.Text);
            Enlazar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Persona> listaTemp = (from p in personas
                                       where p.Nombre.IndexOf(textBox1.Text) > -1
                                       select p).ToList();

            Enlazar(listaTemp);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            personas.Sort();
            Enlazar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Persona p = (Persona)listBox1.SelectedItem;

            Persona clon =(Persona)p.Clone();

            listBox2.Items.Add(p);
            listBox2.Items.Add(clon);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == listBox2.SelectedItem)
            {
                MessageBox.Show("Es el original");
            }
            else
            {
                MessageBox.Show("Es el CLON");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (Persona p =new Persona("aaa",33))
            {

                p.Edad = 33;
                p.Dispose();
           
            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (Form1 frm = new Form1())
            {

                frm.Dispose();
            }
        }
    }
}
