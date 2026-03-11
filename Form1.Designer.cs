namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.barBusqueda = new System.Windows.Forms.TextBox();
            this.selecPanel = new System.Windows.Forms.Panel();
            this.barScroll = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selecPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(245, 401);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(199, 34);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // barBusqueda
            // 
            this.barBusqueda.Location = new System.Drawing.Point(279, 12);
            this.barBusqueda.Name = "barBusqueda";
            this.barBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.barBusqueda.Size = new System.Drawing.Size(334, 20);
            this.barBusqueda.TabIndex = 2;
            this.barBusqueda.Text = "Ingrese su busqueda...";
            this.barBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selecPanel
            // 
            this.selecPanel.Controls.Add(this.barScroll);
            this.selecPanel.Location = new System.Drawing.Point(12, 12);
            this.selecPanel.Name = "selecPanel";
            this.selecPanel.Size = new System.Drawing.Size(216, 423);
            this.selecPanel.TabIndex = 3;
            // 
            // barScroll
            // 
            this.barScroll.Location = new System.Drawing.Point(192, 0);
            this.barScroll.Name = "barScroll";
            this.barScroll.Size = new System.Drawing.Size(24, 423);
            this.barScroll.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar Libro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selecPanel);
            this.Controls.Add(this.barBusqueda);
            this.Controls.Add(this.btnDevolver);
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "LibreriaApp";
            this.selecPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.TextBox barBusqueda;
        private System.Windows.Forms.Panel selecPanel;
        private System.Windows.Forms.VScrollBar barScroll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

