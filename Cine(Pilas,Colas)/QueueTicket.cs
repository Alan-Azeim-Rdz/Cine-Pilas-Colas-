using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class QueueTicket
    {

        public Node head; // Primer elemento (frente de la cola)


        public QueueTicket()
        {
            head = null;
        }

        public void Enqueue(Ticket_Cine ticket)
        {
            Node newNode = new Node(ticket); // Crea un nuevo nodo con el ticket

            if (head == null) // Si la cola está vacía
            {
                head = newNode; // El nuevo nodo es la cabeza de la cola
            }
            else
            {
                Node current = head;
                // Recorre la cola hasta el último nodo
                while (current.Next != null)
                {
                    current = current.Next;
                }
                // Asigna el nuevo nodo como el siguiente del último nodo
                current.Next = newNode;
            }
        }


        public string Dequeue()
        {
            string ticket = "";
            if (head == null) // Si la cola está vacía
            {
                ticket = "La cola está vacía.";
                return ticket; // Devuelve una cadena vacía si la cola está vacía
            }

            // Guarda el ticket del nodo en el frente
            ticket = head.Ticket.ToString();
            MessageBox.Show(ticket);

            // Mueve la cabeza al siguiente nodo (elimina el primero)
            head = head.Next;

            return ticket; // Devuelve el ticket del nodo eliminado
        }



        public string Peek() 
        {
            string Ticket = "";
            if (head == null)
            {
                MessageBox.Show("La cola esta vacia, nadie esta en espera");
                Ticket = "No hay personas en espera";
            }
            else
            {
                Ticket = "\n" + head.Ticket.ToString();
            }
            return Ticket;
        }

        public bool IsEmpty() => head == null;

        public int Size()
        {
            int count = 0;
            Node current = head;

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
