using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Modelos;

namespace WindowsFormsApp1.Modelos
{
    public class Usuario : Persona
    {
        public string Carnet { get; set; }

        public override string MostrarInformacion()
        {
              return Carnet + " - " + Nombre + " - " + Email;
        }

    }
}
