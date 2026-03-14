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
    public partial class FrmPrestamos : Form

    {
        public Usuario UsuarioPrestamo { get; set; }
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarPrestamo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))

            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            UsuarioPrestamo = new Usuario
            {
                Carnet = txtCarnet.Text,
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
            }; 
                
            this.DialogResult = DialogResult.OK;
            this.Close();
                    
                
        }
    }
}
