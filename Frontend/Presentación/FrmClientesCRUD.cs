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
    public partial class FrmClientesCRUD : Form
    {
        ServiciosFactory factoria_servicios;
        GestorCliente gestor_cliente;
        List<Clientes> lista_clientes = new List<Clientes>();
        ModeloFactory factoria = new ModeloFactory();
        public FrmClientesCRUD(ServiciosFactory fact)
        {
            InitializeComponent();
            CenterToParent();
            factoria_servicios = fact;
            gestor_cliente = (GestorCliente)factoria_servicios.CreaObjeto("GestorCliente");
        }

        private void FrmClientesCRUD_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarDgv();
            cbxNuevoCliente.Checked = false;
            btnInsertar.Enabled = false;
        }

        private async void CargarDgv()
        {
            lista_clientes = await gestor_cliente.GetTodosClientes();
            foreach (Clientes c in lista_clientes)
            {
                dgvClientes.Rows.Add(new object[] {c.id_cliente, c.nombre_raz_social, c.tipos_cliente.tipo_cliente,
                c.tipos_Identificacion.tipo_identificacion, c.identificacion, c.Direccion, c.barrio.nom_barrio});
            }
        }

        private async void CargarCombos()
        {
            List<Tipo_cliente> lista_tp_cliente = await gestor_cliente.GetTipoCliente();
            cboTipoCliente.DataSource = lista_tp_cliente;
            cboTipoCliente.SelectedIndex = -1;
            List<Tipo_identificacion> lista_tp_ident = await gestor_cliente.ObtenerTipoIdentificacion();
            cboTipoIden.DataSource = lista_tp_ident;
            cboTipoIden.SelectedIndex = -1;
            List<Barrio> lista_barrios = await gestor_cliente.GetBarrios();
            cboBarrio.DataSource = lista_barrios;
            cboBarrio.SelectedIndex = -1;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvClientes.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                string columnName = dgvClientes.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "BtnModificar":
                        if (dgvClientes.Rows[e.RowIndex].Cells[0].Value != null)
                        {
                            if (ValidarDatos())
                            {
                                //int valorInt = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
                                Clientes cliente = (Clientes)factoria.CreaObjeto("cliente");
                                cliente.tipos_cliente = (Tipo_cliente)cboTipoCliente.SelectedItem;
                                cliente.tipos_Identificacion = (Tipo_identificacion)cboTipoIden.SelectedItem;
                                cliente.barrio = (Barrio)cboBarrio.SelectedItem;
                                cliente.identificacion = Convert.ToInt32(txtIden.Text);
                                cliente.nombre_raz_social = txtNombre.Text;
                                cliente.Direccion = txtDireccion.Text;
                                cliente.id_cliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
                                string resultado = await gestor_cliente.ModificarCliente(cliente);
                                dgvClientes.Rows.Clear();
                                Limpiar();
                                CargarDgv();
                            }
                        }
                        break;

                    case "btnBorrar":
                        if (dgvClientes.Rows[e.RowIndex].Cells[0].Value != null)
                        {
                            int valorInt = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells[0].Value);
                            string resultado = await gestor_cliente.BorrarCliente(valorInt);
                            dgvClientes.Rows.Clear();
                            Limpiar();
                            CargarDgv();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void Limpiar()
        {
            cboTipoCliente.SelectedIndex = -1;
            cboTipoIden.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtIden.Text = "";
            cbxNuevoCliente.Checked = false;
        }

        private bool ValidarDatos()
        {
            if (txtDireccion.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar una dirección del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDireccion.Focus();
                return false;
            }
            if (txtIden.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar una identificación del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIden.Focus();
                return false;
            }
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Debe indicar un nombre del cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return false;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un barrio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboBarrio.Focus();
                return false;
            }
            if (cboTipoCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoCliente.Focus();
                return false;
            }
            if (cboTipoIden.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de identificación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipoIden.Focus();
                return false;
            }
            return true;
        }

        private void txtIden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private void cbxNuevoCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNuevoCliente.Checked == true)
                btnInsertar.Enabled = true;
            else
                btnInsertar.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertCliente();
        }

        private async void InsertCliente()
        {
            if (ValidarDatos())
            {
                Clientes cliente = (Clientes)factoria.CreaObjeto("cliente");
                cliente.tipos_cliente = (Tipo_cliente)cboTipoCliente.SelectedItem;
                cliente.tipos_Identificacion = (Tipo_identificacion)cboTipoIden.SelectedItem;
                cliente.barrio = (Barrio)cboBarrio.SelectedItem;
                cliente.identificacion = Convert.ToInt32(txtIden.Text);
                cliente.nombre_raz_social = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                bool? resultado = await gestor_cliente.IngresarCliente(cliente);
                if (resultado == true)
                    MessageBox.Show("Cliente ingresado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Cliente no se pudo ingresar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvClientes.Rows.Clear();
                CargarDgv();
                Limpiar();
            }
        }
    }
}
