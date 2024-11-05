using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Estructura_de_datos_Pilas_y_Colas
{
    internal class Node
    {
        public Ticket_Cine Ticket { get; set; }
        public Node Next { get; set; } // Apunta al siguiente nodo

        public Node()
        {
            Ticket = null;
            Next = null;
        }

        public Node(Ticket_Cine ticket)
        {
            Ticket = ticket;
            Next = null; // El siguiente nodo inicialmente es null
        }

        public override string ToString()
        {
            return Ticket.ToString();
        }
    }
}
