using Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Formularios
{
    public partial class frmMantenimientoZapatos : Form
    {
        public frmMantenimientoZapatos()
        {
            InitializeComponent();
        }

        private void frmMantenimientoZapatos_Load(object sender, EventArgs e)
        {
            cargarEspecialidad();
            cargarZapatos();
        }

        private void cargarZapatos()
        {
            dgvProductosAlmaceen.DataSource = null;
            dgvProductosAlmaceen.DataSource = Zapato.cargarzapatos();
            dgvProductosAlmacen.DataSource = null;
            dgvProductosAlmacen.DataSource = Zapato.cargarzapatos();
        }

        private void cargarEspecialidad()
        {
            cbCategoriaa.DataSource = null;
            cbCategoriaa.DataSource = Categoria.cargarCategoria();
            cbCategoriaa.DisplayMember = "Nombre";
            cbCategoriaa.ValueMember = "Id";
            cbCategoriaa.SelectedIndex = -1;
            cbCategoria.DataSource = null;
            cbCategoria.DataSource = Categoria.cargarCategoria();
            cbCategoria.DisplayMember = "Nombre";
            cbCategoria.ValueMember = "Id";
            cbCategoria.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Zapato zapato = new Zapato();
                zapato.Nombre = txtNombreZapat.Text;
                zapato.Precio = double.Parse(txtPrecio.Text);
                zapato.FechaCreacion = dtpFechaIngreso.Value;
                zapato.IdCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                zapato.ImagenURL = "";
                zapato.insertarZapatos();
                cargarZapatos();
                MessageBox.Show("Excelente datos registrados", "Datos correctos", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Error de iformación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Zapato zapatoEliminar = new Zapato();
            int id = int.Parse(dgvProductosAlmaceen.CurrentRow.Cells[0].Value.ToString());
            string registroAEliminar = dgvProductosAlmaceen.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show("¿Quieres eliminar este registro?" + registroAEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (zapatoEliminar.eliminarZapato(id) == true)
                {
                    MessageBox.Show("Registro eliminado\n" + registroAEliminar, "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarZapatos();
                }
            }
            else
            {
                MessageBox.Show("Registro no eliminado", "seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
