using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EjemploForms
{
    class MITextbox:TextBox
    {

        private bool requerido;

        public bool Requerido
        {
            get { return requerido; }
            set { requerido = value; }
        }


        public bool Validar()
        {
            bool ok = !string.IsNullOrWhiteSpace(this.Text) || !requerido;
            if(ok)
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.Coral;
            }
            return ok;
        }

    }
}
