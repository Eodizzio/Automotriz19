using DDL.Dominio;
using DDL.Servicios;
using Frontend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Presentación
{
    public partial class FrmProductos : Form
    {
        ServiciosFactory factoria_servicios;
        GestorProductos gestor_producto;
        List<Productos> lista_productos = new List<Productos>();
        ModeloFactory factoria = new ModeloFactory();
        public FrmProductos(ServiciosFactory fact)
        {
            InitializeComponent();
            CenterToParent();
            factoria_servicios = fact;
            gestor_producto = (GestorProductos)factoria_servicios.CreaObjeto("GestorProductos");
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDgv();
            CargarCombos();
        }

        private async void CargarCombos()
        {
            List<Colores> lista_colores = await gestor_producto.GetColor();
            cboColores.DataSource = lista_colores;
            cboColores.SelectedIndex = -1;
            List<Marca> lista_marcas = await gestor_producto.GetMarcas();
            cboMarca.DataSource = lista_marcas;
            cboMarca.SelectedIndex = 1;
            List<Pais> lista_paises = await gestor_producto.GetPaises();
            cboPais.DataSource = lista_paises;
            cboPais.SelectedIndex = 1;
            List<Tipo_producto> lista_tipos_productos = await gestor_producto.GetTiposProductos();
            cboTipoProd.DataSource = lista_tipos_productos;
            cboTipoProd.SelectedIndex = 1;
        }

        private async void CargarDgv()
        {
            lista_productos = await gestor_producto.GetTodosProductos();
            foreach (Productos p in lista_productos)
            {
                dgvProductos.Rows.Add(new object[] {p.cod_producto,p.tipo_producto.tipo_producto,p.Marca.marca,
                p.Modelo.modelo,p.Origen.pais,p.Descripcion,p.PrecioUnitario,p.Color.color});
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            InsertarProducto();
        }

        private async void InsertarProducto()
        {
            if (ValidarDatos())
            {
                Productos nuevo_producto = (Productos)factoria.CreaObjeto("producto");
                Modelo nuevo_modelo = (Modelo)factoria.CreaObjeto("modelo");
                nuevo_producto.tipo_producto = (Tipo_producto)cboTipoProd.SelectedItem;
                nuevo_producto.Marca = (Marca)cboMarca.SelectedItem;
                nuevo_producto.Origen = (Pais)cboPais.SelectedItem;
                nuevo_producto.Color = (Colores)cboColores.SelectedItem;
                nuevo_modelo.modelo = txtModelos.Text;
                nuevo_producto.Modelo = nuevo_modelo;
                nuevo_producto.Descripcion = txtDescripcion.Text;
                nuevo_producto.PrecioUnitario = Convert.ToInt32(txtPrecio.Text);
                bool? resultado = await gestor_producto.InsertarProducto(nuevo_producto);
                if (resultado == true)
                    MessageBox.Show("Producto ingresado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Producto no se pudo ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvProductos.Rows.Clear();
                CargarDgv();
                Limpiar();

            }
        }

        private void Limpiar()
        {
            cboColores.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            cboPais.SelectedIndex = -1;
            cboTipoProd.SelectedIndex = -1;
            txtDescripcion.Text = String.Empty;
            txtModelos.Text = String.Empty;
            txtPrecio.Text = String.Empty;
        }

        private bool ValidarDatos()
        {
            if (cboColores.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Color.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboColores.Focus();
                return false;
            }
            if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Marca.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboMarca.Focus();
                return false;
            }
            if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoProd.Focus();
                return false;
            }
            if (cboPais.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Pais.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboPais.Focus();
                return false;
            }
            if (txtModelos.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Modelo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtModelos.Focus();
                return false;
            }
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una Descripción.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescripcion.Focus();
                return false;
            }
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Focus();
                return false;
            }
            return true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // Cancelar la tecla para que no se procese
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private async void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                string columnName = dgvProductos.Columns[e.ColumnIndex].Name;
                if (columnName == "colBorrar")
                {
                    if (dgvProductos.Rows[e.RowIndex].Cells[0].Value != null)
                    {
                        int valorInt = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[0].Value);
                        string resultado = await gestor_producto.BorrarProducto(valorInt);
                        dgvProductos.Rows.Clear();
                        Limpiar();
                        CargarDgv();
                    }
                }
            }
        }
    }
}
