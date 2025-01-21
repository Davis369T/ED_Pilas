using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class nodo
    {
        private string nombre;
        private nodo siguiente;

        public string Nombre { get => nombre; set => nombre = value; }
        internal nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
