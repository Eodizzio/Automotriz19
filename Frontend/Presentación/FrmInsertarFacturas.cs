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
    public partial class FrmInsertarFacturas : Form
    {
        ServiciosFactory factoria_servicios;
        GestorCliente gestor_cliente;
        GestorProductos gestor_productos;
        GestorFactura gestor_facturas;
        ModeloFactory factoria = new ModeloFactory();
        private int totalFactura = 0;
        public FrmInsertarFacturas(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria_servicios = fact;
            gestor_cliente = (GestorCliente)factoria_servicios.CreaObjeto("GestorCliente");
            gestor_productos = (GestorProductos)factoria_servicios.CreaObjeto("GestorProductos");
            gestor_facturas = (GestorFactura)factoria_servicios.CreaObjeto("GestorFacturas");
            CenterToParent();

        }

        private void FrmInsertarFacturas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            dtpFecha.Value = DateTime.Now;
            dtpFecha.Enabled = false;
        }

        private async void CargarCombos()
        {
            List<Clientes> lista_clientes = await gestor_cliente.GetTodosClientes();
            cboCliente.DataSource = lista_clientes;
            cboCliente.SelectedIndex = -1;
            List<Productos> lista_productos = await gestor_productos.GetTodosProductos();
            cboProductos.DataSource = lista_productos;
            cboProductos.SelectedIndex = -1;
            List<Forma_Pago> list_formas_pago = await gestor_facturas.GetFormasPago();
            cboFormaPago.DataSource = list_formas_pago;
            cboFormaPago.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDetalle())
            {
                ValidarDetalle();
                CargarDgv();
                cboCliente.Enabled = false;
                cboFormaPago.Enabled = false;
                cboProductos.SelectedIndex = -1;
                txtCantidad.Text = String.Empty;
                txtPrecio.Text = String.Empty;
            }
        }

        private bool ValidarDetalle()
        {
            if (cboCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una Forma de Pago.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtCantidad.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una Cantidad.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtPrecio.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void CargarDgv()
        {
            Productos producto = (Productos)factoria.CreaObjeto("producto");
            producto = (Productos)cboProductos.SelectedItem;
            int cantidad = Convert.ToInt32(txtCantidad.Text.ToString());
            int precio = Convert.ToInt32(txtPrecio.Text.ToString());
            int total = precio * cantidad;
            totalFactura += total;
            txtTotal.Text = totalFactura.ToString();
            dgvDetallesFacturas.Rows.Add(new object[] { producto.cod_producto, producto.Marca.marca, producto.Modelo.modelo, producto.Color.color, cantidad, precio, total });
        }

        private bool Validar()
        {
            if (dgvDetallesFacturas.RowCount == 0)
            {
                MessageBox.Show("Debe ingresar un detalle.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        //Validación para que no ingresen letras en cantidad
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        //Validación para que no ingresen letras en precio
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cboFormaPago.Enabled = true;
            Limpiar();
            dgvDetallesFacturas.Rows.Clear();

        }

        private void Limpiar()
        {
            cboProductos.SelectedIndex = -1;
            cboCliente.SelectedIndex = -1;
            cboFormaPago.SelectedIndex = -1;
            txtCantidad.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtTotal.Text = String.Empty;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                InsertarFacturas();
                Limpiar();
                dgvDetallesFacturas.Rows.Clear();
                cboCliente.Enabled = true;
                cboFormaPago.Enabled = true;
            }
        }

        private async void InsertarFacturas()
        {
            Facturas factura = (Facturas)factoria.CreaObjeto("factura");
            factura.Fecha = dtpFecha.Value;
            factura.FormaPago = (Forma_Pago)cboFormaPago.SelectedItem;
            factura.Cliente = (Clientes)cboCliente.SelectedItem;
            foreach (DataGridViewRow fila in dgvDetallesFacturas.Rows)
            {
                Detalle_factura detalle = (Detalle_factura)factoria.CreaObjeto("detalle_factura");
                detalle.producto.cod_producto = Convert.ToInt32(fila.Cells[0].Value);
                detalle.cantidad = Convert.ToInt32(fila.Cells[4].Value);
                detalle.pre_unitario = Convert.ToInt32(fila.Cells[5].Value);
                factura.AgregarDetalles(detalle);
            }
            bool? ok = await gestor_facturas.IngresarFactura(factura);
            if (ok == true)
                MessageBox.Show("Factura no se pudo ingresar.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Factura ingresada con éxito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
