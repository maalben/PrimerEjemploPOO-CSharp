using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEjemploPOO
{
    public class Calculo
    {
        //Definir las características - ATRIBUTOS
        public double numero1;
        public double numero2;

        //Definir acciones - METODOS
        public double sumar()
        {
            return (this.numero1 + this.numero2);
        }

        public double restar()
        {
            return (this.numero1 - this.numero2);
        }
    }
}
