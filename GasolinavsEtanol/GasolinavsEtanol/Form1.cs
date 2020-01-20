using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasolinavsEtanol
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         
      }

      private void btnCalcular_Click(object sender, EventArgs e)
      {
         double valorAlc, valorGas;

         valorAlc = Convert.ToDouble(txtEtanol.Text);
         valorGas = Convert.ToDouble(txtGasolina.Text);


         lblResultado.Text = Operacao(valorAlc, valorGas);

      }
      private string Operacao(double valorAlc, double valorGas)
      {
         double resultado = valorAlc / valorGas;

         if (resultado <= 0.7)
         {
            lblResultado.ForeColor = Color.Green;
            return "ETANOL";
         }
         else
         {
            lblResultado.ForeColor = Color.Red;
            return "GASOLINA";
         }
      }
   }
}
