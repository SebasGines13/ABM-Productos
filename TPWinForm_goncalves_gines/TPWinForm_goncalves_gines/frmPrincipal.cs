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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void TSMenuAgregar_Click(object sender, EventArgs e)
        {
            foreach ( var item in Application.OpenForms)    //Evita que se puedan crear mas de 1 ventana del mismo tipo
            {
                if (item.GetType() == typeof(frmAgregar))
                    return;
            }

            frmAgregar ventana = new frmAgregar();
            ventana.Show();
            ventana.MdiParent = this;
                    
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListar ventana = new frmListar();
            ventana.Show();
            ventana.MdiParent = this;
        }

    }
}
