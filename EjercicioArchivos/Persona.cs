using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArchivos
{
    class Contacto
    {
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string telefono { set; get; }
        public string correo { set; get; }

        public Contacto()
        {

        }
        public Contacto(string nombre, string apellido, string telefono, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public override string ToString()
        {
            return string.Format("Nombre: {0} Apellido: {1} Teléfono: {2} Correo: {3}", nombre, apellido, telefono, correo);
        }
    }
}
