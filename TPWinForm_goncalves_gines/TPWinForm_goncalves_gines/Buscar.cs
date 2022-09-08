using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_goncalves_gines
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void btnCancelarBuscar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            /*this.FormClosed += new FormClosedEventHandler(cerrarform);*/
        }
        private void cerrarform(object sender, EventArgs e)
        {
            /*this.Close();*/

        }
    }
}
