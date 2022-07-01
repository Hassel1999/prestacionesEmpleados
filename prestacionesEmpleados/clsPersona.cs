using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestacionesEmpleados
{
    public class clsPersona
    {
        //atributos
        private static double codigo;
        private static double nombre;
        private static double apellido;

        //propiedades accesora
        public static double Codigo { get => codigo; set => codigo = value; }
        public static double Nombre { get => nombre; set => nombre = value; }
        public static double Apellido { get => apellido; set => apellido = value; }
    }
}
