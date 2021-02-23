using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        int num = 0;
        int muertes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TicTac(object sender, EventArgs e)
        {
            customControl12.Errores = num;
            num++;
            if (num > 7)
            {
                num = 0;
            }
        }

        private void Cambia(object sender, EventArgs e)
        {
            lblerrores.Text = "" + num;
        }

        private void Muerto(object sender, EventArgs e)
        {
            muertes++;
            label2.Text = "Muerto " + muertes;
        }
    }
}
