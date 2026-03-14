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
            this.botonAgregar = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(15, 407);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(143, 34);
            this.btnDevolver.TabIndex = 1;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
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
            this.button1.Location = new System.Drawing.Point(643, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva Busqueda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(164, 407);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(143, 34);
            this.botonAgregar.TabIndex = 5;
            this.botonAgregar.Text = "Agregar Libro";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.columnaTitulo,
            this.columnaAutor,
            this.columnaEstado});
            this.dgvLibros.Location = new System.Drawing.Point(15, 74);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(773, 310);
            this.dgvLibros.TabIndex = 6;
            this.dgvLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // columnaID
            // 
            this.columnaID.HeaderText = "Id";
            this.columnaID.Name = "columnaID";
            this.columnaID.ReadOnly = true;
            // 
            // columnaTitulo
            // 
            this.columnaTitulo.HeaderText = "Titulo";
            this.columnaTitulo.Name = "columnaTitulo";
            this.columnaTitulo.ReadOnly = true;
            // 
            // columnaAutor
            // 
            this.columnaAutor.HeaderText = "Autor";
            this.columnaAutor.Name = "columnaAutor";
            this.columnaAutor.ReadOnly = true;
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(313, 407);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 34);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar Libro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(462, 407);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(143, 34);
            this.btnPrestar.TabIndex = 8;
            this.btnPrestar.Text = "Prestar Libro";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.botonAgregar);
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
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnPrestar;
    }
}

