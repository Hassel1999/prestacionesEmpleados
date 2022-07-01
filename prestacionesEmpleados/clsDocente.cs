using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestacionesEmpleados
{
    public class clsDocente : clsPersona
    {
        //Atributos
        private double salario; 
        private int año_laboral;

        //Propiedades
        public double Salario { get => salario; set => salario = value; }
        public int Año_laboral { get => año_laboral; set => año_laboral = value; }

        //Metodos
        public double Auxilio_de_cesantía()
        {
            double Auxilio = Salario * Año_laboral;
            return Auxilio;
        }//Permite calcular el Auxilo de cesantia
        public double Aguinaldo_DecimoCuartoMes()
        {
            double ADCM = Salario * 0.50;
            return ADCM;
        }//Permite calcular el Aguinaldo y el decimo cuarto mes
    }
}
