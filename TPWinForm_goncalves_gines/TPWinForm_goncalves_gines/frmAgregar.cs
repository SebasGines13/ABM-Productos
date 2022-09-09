using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_goncalves_gines
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

 
        private void btnCancelarAgregar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            Articulo artic = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                //artic.Codigo = int.Parse(txtCodigo.Text);
                artic.Codigo = txtCodigo.Text;
                artic.Nombre = txtNombre.Text;
                artic.Descripcion = txtDescripcion.Text;
                artic.ImagenUrl = txtImagenURL.Text;
                artic.Marca = (Marca)cbxMarca.SelectedItem;
                artic.Categoria = (Categoria)cbxCategoria.SelectedItem;

                artNegocio.Agregar(artic);
                MessageBox.Show("Cargado exitosamente");
                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
