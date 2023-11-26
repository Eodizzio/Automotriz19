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
    public partial class FrmLogin : Form
    {
        ServiciosFactory factory = new ServiciosFactory();
        public FrmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPass.Text;

            GestorHash gestor = new GestorHash();

            bool result = await gestor.ComparacionHash(password, usuario);

            if (result)
            {
                FrmPrincipal principalForm = (FrmPrincipal)factory.CreaObjeto("FrmPrincipal");
                principalForm.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
