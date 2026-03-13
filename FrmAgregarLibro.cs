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
    public partial class FrmAgregarLibro : Form
        
    {

        public Libro NuevoLibro { get; set; }
        public FrmAgregarLibro()
        {
            InitializeComponent();
        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textID.Text) ||
                string.IsNullOrWhiteSpace(textTitulo.Text) ||
                string.IsNullOrWhiteSpace(textAutor.Text))
            {
                MessageBox.Show("Completa todo los campos");
                return;
            }

            int id; 
            if (!int.TryParse(textID.Text, out id))
            {
                MessageBox.Show("El ID debe ser numérico");
                return;
            }

            NuevoLibro = new Libro
            {
                ID = id,
                Titulo = textTitulo.Text,
                Autor = textAutor.Text,
                Disponible = true
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
