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
        private Articulo articulo = null;
        int cont = 0;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo artic)
        {
            InitializeComponent();
            this.articulo = artic;
            Text = "Modificar Articulo";
            lblTituloNuevoArticulo.Text = "Modificar Articulo";
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
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.SelectedIndex = -1;    //Para que nazca sin ninguna opcion seleccionada
                cbxCategoria.SelectedIndex = -1;
                

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenURL.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltroMarca() 
        {
            if ( cbxMarca.SelectedIndex < 0 ) {
                MessageBox.Show("Debe seleccionar un valor para Marca");
                return true;
            }
            return false;
        }
        private bool validarFiltroCategoria()
        {
            if ( cbxCategoria.SelectedIndex < 0 )
            {
                MessageBox.Show("Debe seleccionar un valor para Categoria");
                return true;
            }
            return false;
        }
        private bool validarSoloNumeros(string cad) 
        {
            foreach(char caracter in cad) 
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void validacionEntrada()
        {          
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Falta cargar el campo Codigo");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Falta cargar el campo Nombre");
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Falta cargar el campo Descripcion");
            }
            if (string.IsNullOrEmpty(txtImagenURL.Text))
            {
                MessageBox.Show("Falta cargar el campo Imagen URL");
            }          
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Falta cargar el campo Precio");
            }
            if (validarSoloNumeros(txtPrecio.Text))
            {
                MessageBox.Show("Solo puede ingresar numeros en el campo Precio");              
            }
            validarFiltroMarca();
            validarFiltroCategoria();                                  
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                {  // si está nulo, es porque es un alta de articulo
                    articulo = new Articulo();
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.ImagenUrl = txtImagenURL.Text;
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    validacionEntrada();
                    artNegocio.Agregar(articulo);
                    MessageBox.Show("¡Agregado exitosamente!");
                }
                else { MessageBox.Show("Faltan Cargar Datos"); }

                if (articulo.Id != 0)   //Ver como validar esto 
                {
                    artNegocio.Modificar(articulo);
                    MessageBox.Show("¡Modificado exitosamente!");
                }

                Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("El formato no corresponde con este campo");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }                               
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://media.istockphoto.com/vectors/image-preview-icon-picture-placeholder-for-website-or-uiux-design-vector-id1222357475?k=20&m=1222357475&s=170667a&w=0&h=YGycIDbBRAWkZaSvdyUFvotdGfnKhkutJhMOZtIoUKY=");
            }
        }

        private void txtImagenURL_Leave(object sender, EventArgs e)
        {
            if (txtImagenURL.Text == "")
            {
                txtImagenURL.BackColor = Color.DarkSalmon;
                cont++;
            }
            else
            {
                txtImagenURL.BackColor = System.Drawing.SystemColors.Control;
                cargarImagen(txtImagenURL.Text);
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.BackColor = Color.DarkSalmon;
                cont++;
            }
            else txtCodigo.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.DarkSalmon  ;
                cont++;
            }
            else txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.DarkSalmon;
                cont++;
            }
            else txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "") 
            {
                txtPrecio.BackColor = Color.DarkSalmon;
                cont++;
            }
            else { txtPrecio.BackColor = System.Drawing.SystemColors.Control; }
        }
    }
}
