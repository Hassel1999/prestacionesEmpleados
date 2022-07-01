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
            //confirmacion si eso deseea hacer una limpieza
            DialogResult=(MessageBox.Show("Desea limpiar los campos?"," ",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if (DialogResult == DialogResult.Yes)
            {
                //limpieza de los textbox
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
            //validacion del textbox codigo (solo acepta numero y borrar)
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo puede ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de textbox nombre (solo acepta letras, espacio y borrar)
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo puede ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion de textbox apellido (solo acepta letras, espacio y borrar)
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo puede ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void cmbSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //usamos try para detectar alguna exepcion
            try
            {
                //instancia de los formularios
                frmAdmin admin = new frmAdmin();
                frmDocente docente = new frmDocente();

                //variable para tomar el valor de la seleccion del combobox
                int indice;

                //igualacion de la variable con el valor que se ha seleccionado
                indice=cmbSeleccion.SelectedIndex;

                //Si hay algo seleccionado se ejecutara esta parte del codigo
                if(indice != -1)//si es diferente de -1 hay algo seleccionado
                {
                    switch (indice)
                    {
                        case 0://en caso de que sea el primero la variable indice debe tomar el valor de 0
                            admin.ShowDialog();//Y se mostrara el formilario de administrador
                            break;
                        case 1://en caso de que sea el primero la variable indice debe tomar el valor de 1
                            docente.ShowDialog();//Y se mostrara el formulario de docente
                            break;
                    }
                }
            }
            //en caso de que se encuentre una excepcion se mostrara este mensaje
            catch
            {
                MessageBox.Show("Por favor, No deje campos vacios", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
