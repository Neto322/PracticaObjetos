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
            //Declaración de variable
            Persona persona1;
            //Creación de instancia, alojamiento en memoria
            persona1 = new Persona();
            persona1.nombre = "Juan";
            persona1.apellidos = "Perez";
            persona1.edad = 20;
            persona1.altura = 1.5f;
            Console.WriteLine("Hallo!! " + persona1.nombre + " " + persona1.apellidos + " yo shoi un mago y usted tiene " + persona1.edad + " años y mide " + persona1.altura);
            persona1.cumplirAños();
            persona1.crecimiento(2);
            Console.WriteLine("Wooosshh!! ahora tiene " + persona1.edad + " años y su altura es " + persona1.altura);
            Console.ReadLine();
            
        }
    }
}
