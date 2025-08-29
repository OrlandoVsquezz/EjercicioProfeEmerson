using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.TeamFoundation.Dashboards.WebApi;
using Modelos.Entidades;
using Vista.Formularios;

namespace Vista.UsertControl
{
    public partial class frnLogin : UserControl
    {
        public frnLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                string correo = txtCorreo.Text;
                string contraseña = txtContraseña.Text;

                Usuario us = new Usuario();

                if(us.VerificarLogin(correo, contraseña))
                {
                    MessageBox.Show("Inicio de sesion exitoso");
                    Dashboardd frm = new Dashboardd();
                    frm.Show();
                    Form parentForm = this.FindForm();
                    if(parentForm != null)
                    {
                        parentForm.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Por favor llena los campos requeridos");
            }
        }
    }
}
