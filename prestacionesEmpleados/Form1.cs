using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestacionesEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult=(MessageBox.Show("Desea limpiar los campos?"," ",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (DialogResult == DialogResult.Yes)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = " ";
                    }
                    txtCodigo.Focus();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo puede ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo puede ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                frmAdmin admin = new frmAdmin();
                frmDocente docente = new frmDocente();

                int indice;

                indice=cmbSeleccion.SelectedIndex;

                if(indice != -1)
                {
                    switch (indice)
                    {
                        case 0:
                            admin.ShowDialog();
                            break;
                        case 1:
                            docente.ShowDialog();
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Por favor, No deje campos vacios", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
