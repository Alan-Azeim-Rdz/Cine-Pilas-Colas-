using Estructura_de_datos_Pilas_y_Colas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class NodeStack
    {
        public int Data { get; set; }
        public NodeStack Next { get; set; } // Apunta al siguiente nodo

        public NodeStack()
        {
            Data = 0;
            Next = null; // El siguiente nodo inicialmente es null
        }

        public NodeStack(int data)
        {
            Data = data;
            Next = null; // El siguiente nodo inicialmente es null
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
