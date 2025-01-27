﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
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
        //private Articulo artInicial = null;
        private int modo = 0;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo artic)
        {
            InitializeComponent();
            this.articulo = artic;
            Text = "Modificar Articulo";
            txtCodigo.ReadOnly = true;
            lblTituloNuevoArticulo.Text = "Modificar Articulo";           
        }

        public frmAgregar(Articulo artic, int modo)
        {
            InitializeComponent();
            this.modo = 1;
            this.articulo = artic;           
            Text = "Detalle Articulo";
            lblTituloNuevoArticulo.Text = "Ver Detalle Articulo";
            txtCodigo.ReadOnly = true;
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

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenURL.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    //artInicial = articulo;
                    if(modo == 1)
                    {
                        txtCodigo.Enabled = false;
                        txtNombre.Enabled = false;
                        txtDescripcion.Enabled = false;
                        txtImagenURL.Enabled = false;
                        txtPrecio.Enabled = false;
                        cbxCategoria.Enabled = false;
                        cbxMarca.Enabled = false;
                        btnAceptar.Visible = false;
                        btnModificar.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }      

        private bool esCodigoUnico()
        {
            List<Articulo> listaArticulo;
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            string aux = txtCodigo.Text;

            foreach ( Articulo item in listaArticulo)
            {
                if (item.Codigo == aux) 
                {
                    return true;
                }              
            }
            return false;
        }

        private bool validarNulosOVacios()
        {
            string msj = null;
            decimal number;
            if (string.IsNullOrEmpty(txtCodigo.Text))
                msj += "Falta cargar el campo Codigo";
            if (string.IsNullOrEmpty(txtNombre.Text))
                msj += "\nFalta cargar el campo Nombre";
            if (string.IsNullOrEmpty(txtDescripcion.Text))
                msj += "\nFalta cargar el campo Descripcion";
            if (string.IsNullOrEmpty(txtImagenURL.Text))
                msj += "\nFalta cargar el campo Imagen URL";
            if (string.IsNullOrEmpty(txtPrecio.Text))
                msj += "\nFalta cargar el campo Precio";
            if (!(Decimal.TryParse(txtPrecio.Text, out number)))
                msj += "\nSolo puede ingresar numeros en el campo Precio";
            if (number <= 0)
                msj += "\nEl precio debe ser mayor a cero";
            if (cbxMarca.SelectedIndex < 0)
                msj += "\nDebe seleccionar un valor para Marca";
            if (cbxCategoria.SelectedIndex < 0)
                msj += "\nDebe seleccionar un valor para Categoria";
            if (articulo.Id == 0)
            {
                if (esCodigoUnico())
                    msj += "\nEl codigo ya existe en otro Articulo";
            }
            
            if (msj != null)
                MessageBox.Show(msj);
            return string.IsNullOrEmpty(msj);
        }

        /*private bool sonIdenticos()
        {
            if ((artInicial.Nombre == articulo.Nombre) && (artInicial.Descripcion == articulo.Descripcion) && (artInicial.ImagenUrl == articulo.ImagenUrl))
                if ((artInicial.Precio == articulo.Precio) && (artInicial.Marca == articulo.Marca) && (artInicial.Categoria == articulo.Categoria))
                    return true;
            return false;
        }*/
    
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();  // si está nulo, es porque es un alta de articulo
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenURL.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                if (articulo.Id != 0)
                {                                       
                    if (validarNulosOVacios())
                    {   
                        artNegocio.Modificar(articulo);
                        MessageBox.Show("¡Modificado exitosamente!");
                        Close();
                    }                                            
                }
                else
                {
                    if (validarNulosOVacios())
                    {
                        artNegocio.Agregar(articulo);
                        MessageBox.Show("¡Agregado exitosamente!");
                        Close();
                    }
                    else articulo = null; // Esto lo hacemos porque sino interpretaba que debía realizar un UPDATE y pinchaba como loco!
                }     
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un valor númerico en precio");
                articulo = null;
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
                txtImagenURL.BackColor = Color.DarkSalmon;
            else            
                txtImagenURL.BackColor = System.Drawing.SystemColors.Control;
            cargarImagen(txtImagenURL.Text);        
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")

                txtCodigo.BackColor = Color.DarkSalmon;
            else txtCodigo.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.DarkSalmon  ;
            else txtNombre.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
                txtDescripcion.BackColor = Color.DarkSalmon;
            else txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "") 
                txtPrecio.BackColor = Color.DarkSalmon;
            else { txtPrecio.BackColor = System.Drawing.SystemColors.Control; }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtImagenURL.Enabled = true;
            txtPrecio.Enabled = true;
            cbxCategoria.Enabled = true;
            cbxMarca.Enabled = true;
            btnAceptar.Visible = true;
            btnModificar.Visible = false;
            Text = "Modificar Articulo";
            lblTituloNuevoArticulo.Text = "Modificar Articulo";
        }
    }
}
