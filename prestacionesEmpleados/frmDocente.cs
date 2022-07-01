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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
            //Instancia
            clsPersona persona = new clPersona;
            
            private void frmDocente_Load(object, sender, Eventargs e)
            {
                  lblCodigo.Text = persona.Codigo.ToString();
                  lblNombre.Text = persona.Nombre.ToString();
                  lblApellido.Text = persona.Apellido.ToString();
                  
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
                 persona.Salario = Convert.ToDouble(txtPrestaciones.Text);
                 if(persona.Salario == 0)
                 { 
                      MessageBox.Show("Ingrese un valor positivo", "ERROR");
                      txtSalario.Clear();
                      txtSalario.Focus();
                      
                 }
                 else
                 {
                      persona.calcularPreaviso();
                      persona.calcularAuxilioCesantia();
                      persona.calculoAguinaldo();
                      persona.calculoSueldomensual();

                      txtPreaviso.Text = persona.Preaviso.ToString("n2");
                      txtAuxilioCesantia.Text = persona.AuxilioCesantia.ToString("n2");
                      txtAguinaldo.Text = persona.Aguinaldo.ToString("n2");
                      txtSueldomensual.Text = persona.Sueldomensual.ToString("n2");
                      
                     
    }
}
                 private void btnLimpiar_Click(object sender, EventArgs e)
                 {
                  foreach (Control ctr in this.Controls)
                {
                if (ctr is TextBox)
                {
                    ctr.Text = " ";
                }
                txtSueldobase.Focus();
            }
        }

                private void btnRegresar_Click(object sender, EventArgs e)
               {
                this.Close();
        }
    }
