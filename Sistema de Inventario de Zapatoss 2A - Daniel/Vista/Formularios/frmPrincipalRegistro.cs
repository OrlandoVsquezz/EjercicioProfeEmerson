using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.UsertControl;

namespace Vista.Formularios
{
    public partial class frmPrincipalRegistro : Form
    {
        
        frmRegistrarUsuario frmRegistrarUsuario = new frmRegistrarUsuario();
        frnLogin frnLogin = new frnLogin();

        public frmPrincipalRegistro()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frmRegistrarUsuario);
        }

        private void frmPrincipalRegistro_Load(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frnLogin);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(frnLogin);
        }
    }
}
