namespace Memorama
{
    partial class AcercaDe
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.pctMaresPad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresPad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(419, 321);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 32);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(497, 208);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyenda.Location = new System.Drawing.Point(217, 1);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.ReadOnly = true;
            this.txtLeyenda.Size = new System.Drawing.Size(292, 73);
            this.txtLeyenda.TabIndex = 5;
            this.txtLeyenda.Text = "Memorama Futbolero es un juego creado por:\r\nLuis Enrique Mares Ortega";
            // 
            // pctMaresPad
            // 
            this.pctMaresPad.Image = ((System.Drawing.Image)(resources.GetObject("pctMaresPad.Image")));
            this.pctMaresPad.Location = new System.Drawing.Point(12, 1);
            this.pctMaresPad.Name = "pctMaresPad";
            this.pctMaresPad.Size = new System.Drawing.Size(199, 104);
            this.pctMaresPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaresPad.TabIndex = 7;
            this.pctMaresPad.TabStop = false;
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 357);
            this.Controls.Add(this.pctMaresPad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLeyenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaDe";
            this.Text = "Acerca De Memorama Futbolero";
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresPad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLeyenda;
        private System.Windows.Forms.PictureBox pctMaresPad;
    }
}