using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital;
namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.CrearAgenda(2022, 07, 6, 8, 0, 20, 30, 15);

            dataGridView1.DataSource = medico.Agenda;


        }
    }
}
