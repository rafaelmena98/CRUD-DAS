namespace WindowsFormsApp1
{
    partial class FrmUsuariosEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelRegistros = new System.Windows.Forms.Label();
            this.labelChart = new System.Windows.Forms.Label();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.colCarnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.Location = new System.Drawing.Point(56, 26);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(107, 13);
            this.labelRegistros.TabIndex = 0;
            this.labelRegistros.Text = "Usuarios Registrados";
            // 
            // labelChart
            // 
            this.labelChart.AutoSize = true;
            this.labelChart.Location = new System.Drawing.Point(642, 26);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(106, 13);
            this.labelChart.TabIndex = 1;
            this.labelChart.Text = "Libros mas prestados";
            // 
            // chartLibros
            // 
            chartArea2.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartLibros.Legends.Add(legend2);
            this.chartLibros.Location = new System.Drawing.Point(598, 42);
            this.chartLibros.Name = "chartLibros";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartLibros.Series.Add(series2);
            this.chartLibros.Size = new System.Drawing.Size(437, 300);
            this.chartLibros.TabIndex = 2;
            this.chartLibros.Text = "chart1";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarnet,
            this.colNombre,
            this.colEmail});
            this.dgvUsuarios.Location = new System.Drawing.Point(13, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(565, 369);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(723, 401);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(176, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // colCarnet
            // 
            this.colCarnet.HeaderText = "Carnet";
            this.colCarnet.Name = "colCarnet";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // FrmUsuariosEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 436);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.labelRegistros);
            this.Name = "FrmUsuariosEstadisticas";
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistros;
        private System.Windows.Forms.Label labelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Button btnCerrar;
    }
}