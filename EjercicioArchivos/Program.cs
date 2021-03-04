using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter("directorio.txt"))
            {
                
                string opc = "no";
                while (String.Compare(opc, "salir", true) != 0)
                {
                    Contacto p = new Contacto();
                    Console.Write("Nombre: ");
                    p.nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    p.apellido = Console.ReadLine();
                    Console.Write("Teléfono: ");
                    p.telefono = Console.ReadLine();
                    Console.Write("Correo: ");
                    p.correo = Console.ReadLine();

                    writer.WriteLine(p.ToString());

                    Console.WriteLine("Escribe salir para salir o cualquier otra cosa para agregar otro contacto");
                    opc = Console.ReadLine();
                }
            }
        }
        }
}
