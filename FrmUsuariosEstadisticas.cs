using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class FrmUsuariosEstadisticas : Form
    {
        public FrmUsuariosEstadisticas(List<Usuario> usuarios, List<Prestamo> prestamos)
        {
            InitializeComponent();
            MostrarUsuarios(usuarios);
            MostrarGraficoLibrosMasPrestados(prestamos);
        }

        private void MostrarUsuarios(List<Usuario> usuarios)
        {
            dgvUsuarios.Rows.Clear();

            foreach (Usuario usuario in usuarios)
            {
                dgvUsuarios.Rows.Add(
                usuario.Carnet,
                usuario.Nombre,
                usuario.Email
                );
            }
        }

        private void MostrarGraficoLibrosMasPrestados(List<Prestamo> prestamos)
        {
            chartLibros.Series.Clear();
            chartLibros.ChartAreas.Clear();
            chartLibros.Titles.Clear();

            ChartArea area = new ChartArea();
            chartLibros.ChartAreas.Add(area);

            chartLibros.Titles.Add("Los libros mas prestados");
            Series serie  = new Series();
            serie.ChartType = SeriesChartType.Column;

            Dictionary<string, int> conteoLibros = new Dictionary<string, int>();

            foreach (Prestamo prestamo in prestamos)
            {
                string tituloLibro = prestamo.LibroPrestado.Titulo;
                if (conteoLibros.ContainsKey(tituloLibro))
                {
                    conteoLibros[tituloLibro]++;
                }
                else
                {
                    conteoLibros [tituloLibro] = 1;
                }


                foreach (var item in conteoLibros)
                {
                    serie.Points.AddXY(item.Key, item.Value);
                }

                chartLibros.Series.Add(serie);

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
