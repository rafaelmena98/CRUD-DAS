using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Libro
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Autor {  get; set; }
        public string Titulo { get; set; }
        public bool Disponible { get; set; }

        public Libro()
        {
            Disponible = true;
        }

        public void MarcarPrestado()
        {
            Disponible = false;
        }

        public void MarcarDisponible()
        { 
            Disponible = true;
        }
    }


}
