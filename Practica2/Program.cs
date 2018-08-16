using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Pedrito";
            contacto1.TelefonoCasa = "(644) 115 - 2514";
            contacto1.Dirreccion = "Avenida de anita 2314";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Telefono de casa " + contacto1.TelefonoCasa);
            
            Contacto contacto2 = new Contacto("Maria Navarro","(644) 02 12 32","23343545","Enrique Segobiano","MariaNav21@jotmeil.com");

            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Numero Casa " + contacto2.TelefonoCasa);
            Console.WriteLine("Numero Celular: " + contacto2.TelefonoCelular);
            Console.WriteLine("Dirrecion " + contacto2.Dirreccion);
            Console.WriteLine("Correo " + contacto2.CorreoElectronico);

            Console.ReadLine();

        }
    }
}
