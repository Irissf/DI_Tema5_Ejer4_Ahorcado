using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_Tema5_Ejer4_Ahorcado
{
    public partial class CustomControl1 : Control
    {
        private float tile;
        private float alto;


        public CustomControl1()
        {
            InitializeComponent();
        }

        /*==============================================================================
                    ___  ____ ____ ___  _ ____ ___  ____ ___  ____ ____ 
                    |__] |__/ |  | |__] | |___ |  \ |__| |  \ |___ [__  
                    |    |  \ |__| |    | |___ |__/ |  | |__/ |___ ___]
         ==============================================================================*/

        private int errores = 0;
        [Category ("Ahorcado")]
        [Description("El número de errores, cuantos más tenga, más completo estará el dibujo")]
        public int Errores
        {
            set
            {
                if (value < 0)
                {
                    errores = 0;
                }else if (value > 7)
                {
                    errores = 7;
                }
                else
                {
                    errores = value;
                }
                CambiaErrores?.Invoke(this, EventArgs.Empty);
                Refresh();
            }
            get
            {
                return errores;
            }
        }

        private int anchoComponente = 200;
        [Category ("Ahorcado")]
        [Description("Tamaño del componente, entre 200 y 500")]
        public int AnchoComponente
        {
            set
            {
                if (value < 200)
                {
                    anchoComponente = 200;
                }
                else if (value > 500)
                {
                    anchoComponente = 500;
                }
                else
                {
                    anchoComponente = value;
                }
                Refresh();

            }
            get
            {
                return anchoComponente;
            }
        }

        private Color color = Color.Black;
        [Category ("Ahorcado")]
        [Description("Color de las lineas del gráfico")]
        public Color Color
        {
            set
            {
                color = value;
                Refresh();
            }
            get
            {
                return color;
            }
        }


        /*==============================================================================
                            ____ _  _ ___  ____ _ _  _ ___ 
                            |  | |\ | |__] |__| | |\ |  |  
                            |__| | \| |    |  | | | \|  |
         ==============================================================================*/
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            this.tile = this.anchoComponente / 7;
            this.alto = this.tile * 4;

            Graphics g = pe.Graphics;
            Pen pen = new Pen(this.color);

            //linea
            g.DrawLine(pen, 0f, this.alto, this.anchoComponente, this.alto);

            //cruces
            g.DrawLine(pen, tile * 0.1f, tile * 2.3f, tile * 0.9f, tile * 2.3f); //horizontal
            g.DrawLine(pen, tile * 0.5f, tile * 2f, tile * 0.5f, this.alto); //vertical

            g.DrawLine(pen, tile * 4.7f, tile * 3.2f, tile * 5.3f, tile * 3.2f); //horizontal
            g.DrawLine(pen, tile * 5f, tile * 3f, tile * 5f, this.alto); //vertical

            g.DrawLine(pen, tile * 5.2f, tile * 2.8f, tile * 5.8f, tile * 2.8f); //horizontal
            g.DrawLine(pen, tile * 5.5f, tile * 2.5f, tile * 5.5f, this.alto); //vertical

            g.DrawLine(pen, tile * 6f, tile * 3.2f, tile * 6.6f, tile * 3.2f); //horizontal
            g.DrawLine(pen, tile * 6.3f, tile * 3f, tile * 6.3f, this.alto); //vertical

            //plataforma
            g.DrawRectangle(pen, tile * 1f, tile * 3.7f, tile * 3, tile * 0.3f);
            g.DrawRectangle(pen, tile * 1.2f, 0, tile * 0.2f, tile * 3.7f);
            g.DrawRectangle(pen, tile * 1f, tile * 0.1f, tile * 0.2f, tile * 0.2f);
            g.DrawRectangle(pen, tile * 1.4f, tile * 0.1f, tile * 2.4f, tile *0.2f);

            //ahorcado
            switch (errores)
            {
                case 1:
                    g.DrawLine(pen, tile * 3.3f, tile * 0.3f, tile * 3.3f, tile * 0.7f);//cuerda
                    break;
                case 2:
                    g.DrawEllipse(pen, tile * 3f, tile * 0.7f, tile * 0.6f, tile * 0.6f); //cabeza
                    goto case 1;
                case 3:
                    g.DrawLine(pen, tile * 3.3f, tile * 1.3f, tile * 3.3f, tile * 2.4f);//cuerpo
                    goto case 2;                 
                case 4:
                    g.DrawLine(pen, tile * 3.3f, tile * 1.4f, tile * 3f, tile * 2f);//brazo derecho
                    goto case 3;            
                case 5:
                    g.DrawLine(pen, tile * 3.3f, tile * 1.4f, tile * 3.6f, tile * 2f);//brazo izquierdo
                    goto case 4;                  
                case 6:
                    g.DrawLine(pen, tile * 3.3f, tile * 2.4f, tile * 3f, tile * 3.2f);//pierna dcha
                    goto case 5;                  
                case 7:
                    g.DrawLine(pen, tile * 3.3f, tile * 2.4f, tile * 3.6f, tile * 3.2f);//pierna izq
                    Ahorcado?.Invoke(this, EventArgs.Empty);
                    goto case 6;                 
                default:
                    break;
            }

            pen.Dispose();
        }


        /*==============================================================================
           ____ ____ ____ ____ ____    ____ _  _ ____ _  _ ___ ____ ____ 
           |    |__/ |___ |__| |__/    |___ |  | |___ |\ |  |  |  | [__  
           |___ |  \ |___ |  | |  \    |___  \/  |___ | \|  |  |__| ___]
     ==============================================================================*/
        [Category("Ahorcado")]
        [Description("cambia el numero de errores")]
        public event System.EventHandler CambiaErrores;

        [Category("Ahorcado")]
        [Description("Cuando llegas al tope de errores")]
        public event System.EventHandler Ahorcado;


    }

   
}
