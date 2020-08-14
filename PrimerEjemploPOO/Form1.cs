using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerEjemploPOO
{
    public partial class Form1 : Form
    {
        //Invocación de la clase Cálculos
        Calculo calculo = new Calculo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
 
            calculo.numero1 = double.Parse(txtnumero1.Text);
            calculo.numero2 = double.Parse(txtnumero2.Text);

            MessageBox.Show("La suma de los número es " + calculo.sumar());
            MessageBox.Show("La resta de los número es " + calculo.restar());

            lblresultado.Text = "La suma es "+Convert.ToString(calculo.sumar());

        }
    }
}
