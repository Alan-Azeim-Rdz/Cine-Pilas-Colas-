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
            Node newNode = new Node(ticket); 

            if (IsEmpty()) 
            {
                head = newNode; 
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }


        public string Dequeue()
        {
            if (!IsEmpty()) 
            {

                string DataTicket = head.Ticket.ToString(); 
                head = head.Next;
                return DataTicket;

            }
            return "La cola está vacía.";

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

            return count; // Devuelve el número total de elementos Size: gets the number of objects in the queue 

        }

    }
}
