using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cine_Pilas_Colas_
{
    internal class PriorityTicketQueue
    {

        private Node Prirotyrear;

        private Node Priorityfront; // Nodo en la parte delantera (más alta prioridad)

        public PriorityTicketQueue()
        {
            Priorityfront = null;
            Prirotyrear = null;
        }

        // Método para agregar un ticket a la cola
        public void Enqueue(Ticket_Cine ticket)
        {
            Node newNode = new Node(ticket);

            if (Prirotyrear == null) // Si la cola está vacía
            {
                Priorityfront = newNode;
                Prirotyrear = newNode;
            }
            else
            {
                Prirotyrear.Next = newNode; // El nodo actual al final apunta al nuevo nodo
                Prirotyrear = newNode;      // El nuevo nodo se convierte en el último
            }
        }

        public string Dequeue()
        {
            string Ticket = "";
            if (Priorityfront == null) // Si la cola está vacía
            {
                MessageBox.Show("La cola está vacía.");
                Ticket = "";
                return Ticket;
            }

            Ticket_Cine ticket = Priorityfront.Ticket; // Guardar el ticket del nodo en el frente
            Priorityfront = Priorityfront.Next;                // Mover el frente al siguiente nodo

            if (Priorityfront == null) // Si la cola ahora está vacía, rear también debe ser null
            {
                Prirotyrear = null;
            }

            Ticket = ticket.ToString();

            return Ticket;
        }


        public string Peek()
        {
            if (Priorityfront == null)
            {
               MessageBox.Show("La cola esta vacia, nadie esta en espera");
            }

            string Ticket = "\n" + Priorityfront.Ticket.ToString();
            return Ticket;
        }

        public bool IsEmpty() => Priorityfront == null;

        public int Size()
        {
            int count = 0;
            Node current = Priorityfront;

            // Recorre la cola desde el frente hasta el final
            while (current != null)
            {
                count++;
                current = current.Next; // Avanza al siguiente nodo
            }

            return count; // Devuelve el número total de elementos
        }


    }

}
