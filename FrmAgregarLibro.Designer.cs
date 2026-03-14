namespace WindowsFormsApp1
{
    partial class FrmAgregarLibro
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textAutor = new System.Windows.Forms.TextBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(29, 56);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(180, 20);
            this.textID.TabIndex = 0;
            this.textID.Text = "ID del libro";
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(29, 109);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(180, 20);
            this.textTitulo.TabIndex = 1;
            this.textTitulo.Text = "Agrega el titulo";
            // 
            // textAutor
            // 
            this.textAutor.Location = new System.Drawing.Point(29, 161);
            this.textAutor.Name = "textAutor";
            this.textAutor.Size = new System.Drawing.Size(180, 20);
            this.textAutor.TabIndex = 2;
            this.textAutor.Text = "Agrega el autor";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(13, 277);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(127, 276);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 4;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // FrmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 350);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.textAutor);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.textID);
            this.Name = "FrmAgregarLibro";
            this.Text = "FrmAgregarLibro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textAutor;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonGuardar;
    }
}