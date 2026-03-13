using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Libro> libros = new List<Libro>();
        public Form1()
        {
            

            InitializeComponent();
            CargarLibrosInciales();
            MostrarLibros();
        }

        private void CargarLibrosInciales()
        {

            libros.Add(new Libro
            {
                ID = 1,
                Titulo = " Don Quijote",
                Autor = "Miguel de Cervantes",
                Disponible = true,

            });

            libros.Add(new Libro
            {
                ID = 2,
                Titulo = "Narraciones extraordinarias",
                Autor = "Edgar Allan Poe",
                Disponible = true,
            });

            libros.Add(new Libro
            {
                ID = 3,
                Titulo = "El viejo y el mar",
                Autor = "Ernest Hemingway",
                Disponible= false,
            });

        }

        private void MostrarLibros()
        {
            dgvLibros.Rows.Clear();
            foreach (Libro libro in libros)
            {
                dgvLibros.Rows.Add(
                    libro.ID,
                    libro.Titulo,
                    libro.Autor,
                    libro.Disponible ? "Disponible" : "Prestado"
                    );

            }

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selecPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            { 
                MessageBox.Show("Seleccione un libro");
                return;
            }

            int idLibro = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells[0].Value);
            Libro libroEncontrado = libros.Find(libro => libro.ID == idLibro);

            if (libroEncontrado == null)
            {
                MessageBox.Show("No se pudo encontrar el libro");
                return;
            }

            if (libroEncontrado.Disponible)
            {
                MessageBox.Show("Este libro esta disponible!");
                return;
            }

            libroEncontrado.Disponible = true;
            MostrarLibros();

            MessageBox.Show("Libro devuelto correctamente");
        }

        

    }       


}
