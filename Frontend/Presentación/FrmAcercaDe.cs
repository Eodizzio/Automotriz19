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
    public partial class FrmAcercaDe : Form
    {
        ServiciosFactory factoria;
        public FrmAcercaDe(ServiciosFactory fact)
        {
            InitializeComponent();
            factoria = fact;
            CenterToParent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {

        }
    }
}
