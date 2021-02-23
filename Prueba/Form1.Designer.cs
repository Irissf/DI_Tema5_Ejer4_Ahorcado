
namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.customControl12 = new DI_Tema5_Ejer4_Ahorcado.CustomControl1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblerrores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customControl12
            // 
            this.customControl12.AnchoComponente = 300;
            this.customControl12.Color = System.Drawing.Color.Black;
            this.customControl12.Cursor = System.Windows.Forms.Cursors.Cross;
            this.customControl12.Errores = 0;
            this.customControl12.Location = new System.Drawing.Point(277, 295);
            this.customControl12.Margin = new System.Windows.Forms.Padding(4);
            this.customControl12.Name = "customControl12";
            this.customControl12.Size = new System.Drawing.Size(532, 220);
            this.customControl12.TabIndex = 1;
            this.customControl12.Text = "customControl12";
            this.customControl12.CambiaErrores += new System.EventHandler(this.Cambia);
            this.customControl12.Ahorcado += new System.EventHandler(this.Muerto);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TicTac);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Errores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // lblerrores
            // 
            this.lblerrores.AutoSize = true;
            this.lblerrores.Location = new System.Drawing.Point(372, 103);
            this.lblerrores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblerrores.Name = "lblerrores";
            this.lblerrores.Size = new System.Drawing.Size(0, 17);
            this.lblerrores.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblerrores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customControl12);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DI_Tema5_Ejer4_Ahorcado.CustomControl1 customControl12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblerrores;
    }
}

