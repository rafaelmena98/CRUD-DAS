using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Prestamo
    {
        public int IdPrestamo { get; set;}
        public Libro LibroPrestado { get; set;}
        public Usuario UsuarioPrestamo { get; set;}
        public DateTime FechaPrestamo { get; set;}
        public bool Devuelto { get; set;}
    }
}
