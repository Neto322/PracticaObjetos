using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonoCasa { get; set; }
        public string Dirreccion { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto()
        {
            Nombre = "Nuevo Contacto";
            TelefonoCasa = "(000) 000 - 0000";
            
        }

        public Contacto(string nombre , string telefonocasa , string telefonocelular , string dirreccion , string correoelectronico)
        {
            Nombre = nombre;
            TelefonoCasa = telefonocasa;
            TelefonoCelular = telefonocelular;
            Dirreccion = dirreccion;
            CorreoElectronico = correoelectronico;

        }
       
    }
}
