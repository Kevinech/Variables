namespace Variables.Formularios
{
    partial class FrmArreglo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lblEdadMinima = new System.Windows.Forms.Label();
            this.lblEdadMaxima = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMayoresEdad = new System.Windows.Forms.Label();
            this.lblMenoresEdad = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenoresEdad);
            this.gbEdades.Controls.Add(this.lblMayoresEdad);
            this.gbEdades.Controls.Add(this.lblEdadMinima);
            this.gbEdades.Controls.Add(this.lblEdadMaxima);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdad);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(13, 26);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(230, 412);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            // 
            // lblEdadMinima
            // 
            this.lblEdadMinima.Location = new System.Drawing.Point(10, 307);
            this.lblEdadMinima.Name = "lblEdadMinima";
            this.lblEdadMinima.Size = new System.Drawing.Size(100, 25);
            this.lblEdadMinima.TabIndex = 5;
            this.lblEdadMinima.Text = "Menor: 0";
            // 
            // lblEdadMaxima
            // 
            this.lblEdadMaxima.Location = new System.Drawing.Point(10, 282);
            this.lblEdadMaxima.Name = "lblEdadMaxima";
            this.lblEdadMaxima.Size = new System.Drawing.Size(100, 25);
            this.lblEdadMaxima.TabIndex = 4;
            this.lblEdadMaxima.Text = "Mayor: 0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Location = new System.Drawing.Point(10, 259);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 23);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.Location = new System.Drawing.Point(10, 85);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(187, 147);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(10, 46);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(100, 20);
            this.tbEdad.TabIndex = 1;
            this.tbEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdad_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la edad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMayoresEdad
            // 
            this.lblMayoresEdad.AutoSize = true;
            this.lblMayoresEdad.Location = new System.Drawing.Point(10, 332);
            this.lblMayoresEdad.Name = "lblMayoresEdad";
            this.lblMayoresEdad.Size = new System.Drawing.Size(101, 13);
            this.lblMayoresEdad.TabIndex = 6;
            this.lblMayoresEdad.Text = "Mayores de edad: 0";
            // 
            // lblMenoresEdad
            // 
            this.lblMenoresEdad.AutoSize = true;
            this.lblMenoresEdad.Location = new System.Drawing.Point(10, 360);
            this.lblMenoresEdad.Name = "lblMenoresEdad";
            this.lblMenoresEdad.Size = new System.Drawing.Size(102, 13);
            this.lblMenoresEdad.TabIndex = 7;
            this.lblMenoresEdad.Text = "Menores de edad: 0";
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEdades);
            this.MaximizeBox = false;
            this.Name = "FrmArreglo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arreglo";
            this.Load += new System.EventHandler(this.FrmArreglo_Load);
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblEdadMaxima;
        private System.Windows.Forms.Label lblEdadMinima;
        private System.Windows.Forms.Label lblMayoresEdad;
        private System.Windows.Forms.Label lblMenoresEdad;
    }
}