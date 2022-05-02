using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorValorEntreTres.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(nUDValor1.Value);
            int valor2 = Convert.ToInt32(nUDValor2.Value);
            int valor3 = Convert.ToInt32(nUDValor3.Value);

            if(valor1 == valor2 && valor2 == valor3)
            {
                lblResultado.Text = ("Os valores são iguais");
                return;
            }
             if (valor1 > valor2)
            {
                if (valor1 > valor3) lblResultado.Text =(" O maior é " + valor1);
            }else
            {
                if (valor2 > valor3) lblResultado.Text = (" O maior é " + valor2);
                else lblResultado.Text = (" O maior é " + valor3);
            }
        }
    }
}
