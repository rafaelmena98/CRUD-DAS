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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(43, 401);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(199, 34);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            // 
            // barBusqueda
            // 
            this.barBusqueda.Location = new System.Drawing.Point(242, 12);
            this.barBusqueda.Name = "barBusqueda";
            this.barBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.barBusqueda.Size = new System.Drawing.Size(334, 20);
            this.barBusqueda.TabIndex = 2;
            this.barBusqueda.Text = "Ingrese su busqueda...";
            this.barBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Agregar Libro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.columnaTitulo,
            this.columnaAutor,
            this.columnaEstado});
            this.dgvLibros.Location = new System.Drawing.Point(15, 74);
            this.dgvLibros.Name = "dataGridView1";
            this.dgvLibros.Size = new System.Drawing.Size(773, 310);
            this.dgvLibros.TabIndex = 6;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnaID
            // 
            this.columnaID.HeaderText = "Id";
            this.columnaID.Name = "columnaID";
            // 
            // columnaTitulo
            // 
            this.columnaTitulo.HeaderText = "Titulo";
            this.columnaTitulo.Name = "columnaTitulo";
            // 
            // columnaAutor
            // 
            this.columnaAutor.HeaderText = "Autor";
            this.columnaAutor.Name = "columnaAutor";
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barBusqueda);
            this.Controls.Add(this.btnDevolver);
            this.HelpButton = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "LibreriaApp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.TextBox barBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
    }
}

