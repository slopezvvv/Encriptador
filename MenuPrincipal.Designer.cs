namespace Encriptador
{
    partial class MenuPrincipal
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
            this._labelTextoPlano = new System.Windows.Forms.Label();
            this._labelTextoCifrado = new System.Windows.Forms.Label();
            this._inputTexto = new System.Windows.Forms.TextBox();
            this._inputCifrado = new System.Windows.Forms.TextBox();
            this._botonEncriptar = new System.Windows.Forms.Button();
            this._botonDescencriptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _labelTextoPlano
            // 
            this._labelTextoPlano.AutoSize = true;
            this._labelTextoPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTextoPlano.Location = new System.Drawing.Point(224, 88);
            this._labelTextoPlano.Name = "_labelTextoPlano";
            this._labelTextoPlano.Size = new System.Drawing.Size(125, 25);
            this._labelTextoPlano.TabIndex = 0;
            this._labelTextoPlano.Text = "Texto plano";
            // 
            // _labelTextoCifrado
            // 
            this._labelTextoCifrado.AutoSize = true;
            this._labelTextoCifrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelTextoCifrado.Location = new System.Drawing.Point(227, 144);
            this._labelTextoCifrado.Name = "_labelTextoCifrado";
            this._labelTextoCifrado.Size = new System.Drawing.Size(137, 25);
            this._labelTextoCifrado.TabIndex = 1;
            this._labelTextoCifrado.Text = "Texto cifrado";
            // 
            // _inputTexto
            // 
            this._inputTexto.Location = new System.Drawing.Point(380, 93);
            this._inputTexto.Name = "_inputTexto";
            this._inputTexto.Size = new System.Drawing.Size(147, 20);
            this._inputTexto.TabIndex = 2;
            // 
            // _inputCifrado
            // 
            this._inputCifrado.Location = new System.Drawing.Point(380, 149);
            this._inputCifrado.Name = "_inputCifrado";
            this._inputCifrado.Size = new System.Drawing.Size(147, 20);
            this._inputCifrado.TabIndex = 3;
            // 
            // _botonEncriptar
            // 
            this._botonEncriptar.Location = new System.Drawing.Point(283, 226);
            this._botonEncriptar.Name = "_botonEncriptar";
            this._botonEncriptar.Size = new System.Drawing.Size(244, 39);
            this._botonEncriptar.TabIndex = 4;
            this._botonEncriptar.Text = "Encriptar";
            this._botonEncriptar.UseVisualStyleBackColor = true;
            this._botonEncriptar.Click += new System.EventHandler(this._botonEncriptar_Click);
            // 
            // _botonDescencriptar
            // 
            this._botonDescencriptar.Location = new System.Drawing.Point(283, 288);
            this._botonDescencriptar.Name = "_botonDescencriptar";
            this._botonDescencriptar.Size = new System.Drawing.Size(244, 44);
            this._botonDescencriptar.TabIndex = 5;
            this._botonDescencriptar.Text = "Descencriptar";
            this._botonDescencriptar.UseVisualStyleBackColor = true;
            this._botonDescencriptar.Click += new System.EventHandler(this._botonDescencriptar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._botonDescencriptar);
            this.Controls.Add(this._botonEncriptar);
            this.Controls.Add(this._inputCifrado);
            this.Controls.Add(this._inputTexto);
            this.Controls.Add(this._labelTextoCifrado);
            this.Controls.Add(this._labelTextoPlano);
            this.Name = "MenuPrincipal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelTextoPlano;
        private System.Windows.Forms.Label _labelTextoCifrado;
        private System.Windows.Forms.TextBox _inputTexto;
        private System.Windows.Forms.TextBox _inputCifrado;
        private System.Windows.Forms.Button _botonEncriptar;
        private System.Windows.Forms.Button _botonDescencriptar;
    }
}

