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
    public partial class frmListar : Form
    {
        private List<Articulo> listaArticulo;
        public frmListar()
        {
            InitializeComponent();
        }

        private void btnCancelarListar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
            cboCampo.SelectedIndex = -1;
           
        }
        
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
                limpiarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void limpiarFiltros()
        {
            cboCampo.SelectedIndex = -1;
            cboCriterio.SelectedIndex = -1;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtFiltroAvanzado.Text = null;
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargar();            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if(dgvArticulos.CurrentRow.DataBoundItem != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAgregar modificar = new frmAgregar(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.Id);
                    cargar();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                if(dgvArticulos.Rows.Count == 0)
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCampo.SelectedItem != null)
            {
                string opcion = cboCampo.SelectedItem.ToString();
                if (opcion == "Precio")
                {
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                }
                else
                {
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                }
            }            
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo y el criterio para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Por favor, ingrese un valor númerico en el filtro...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Por favor, ingrese solo números para filtraro...");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if (dgvArticulos.CurrentRow.DataBoundItem != null)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    frmAgregar modificar = new frmAgregar(seleccionado,1);
                    modificar.ShowDialog();
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
