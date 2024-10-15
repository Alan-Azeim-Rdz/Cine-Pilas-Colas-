using System;
using System.Collections;
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

            if (IsEmpty()) // Si la cola está vacía
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
            if (!IsEmpty()) // Si la cola está vacía
            {

                string DataTicket = head.Ticket.ToString(); // Devuelve el ticket del nodo eliminado
                // Mueve la cabeza al siguiente nodo (elimina el primero)
                head = head.Next;
                return DataTicket;

            }
            return "La cola está vacía."; // Devuelve una cadena vacía si la cola está vacía

        }


        public string Peek() 
        {
            if (!IsEmpty())
            {
                return head.Ticket.ToString();

            }
            return "La cola esta vacia, nadie esta en espera";

        }


        public bool IsEmpty() 
        {
            return head == null;
        }

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
