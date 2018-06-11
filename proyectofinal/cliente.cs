using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal
{
    class cliente
    {
        string nit;
        string nombre;
        string apellido;
        string direccion;

        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
