using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok = true;

            foreach(Control c in this.Controls)
            {
                if(c is MITextbox)
                {
                    ok =  ((MITextbox)c).Validar() && ok;

                }

            }

            if(!ok)
            {
                MessageBox.Show("Complete los datos");

            }
        }
    }
}
