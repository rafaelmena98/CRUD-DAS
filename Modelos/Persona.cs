using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Modelos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public virtual string MostrarInformacion()
        {
            return Nombre + " - " + Email;  
        }
       
    }
}
