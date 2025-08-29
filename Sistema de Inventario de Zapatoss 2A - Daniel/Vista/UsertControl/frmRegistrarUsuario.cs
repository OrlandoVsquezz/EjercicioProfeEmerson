using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Formularios;
using Modelos.Entidades;
using System.Web.Http.ModelBinding.Binders;

namespace Vista.UsertControl
{
    public partial class frmRegistrarUsuario : UserControl
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void cargarRoles()
        {
            cbRol.DataSource = null;
            cbRol.DataSource = Usuario.cargarRoles();
            cbRol.DisplayMember = "Nombre";
            cbRol.ValueMember = "id";
            cbRol.SelectedIndex = -1;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Nombre = txtNombre.Text;
            us.Email = txtCorreo.Text;
            us.Clave = BCrypt.Net.BCrypt.HashPassword(txtContraseña.Text);
            us.RollId = Convert.ToInt32(cbRol.SelectedValue);
            if (us.RegistrarUsuario() == true)
            {
                MessageBox.Show("Usuario registrado", "Bienvenido: " + us.Nombre);
                this.Hide();
                frmMantenimientoZapatos frm = new frmMantenimientoZapatos();
                frm.Show();
            }
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
           cargarRoles();
        }
    }
}
