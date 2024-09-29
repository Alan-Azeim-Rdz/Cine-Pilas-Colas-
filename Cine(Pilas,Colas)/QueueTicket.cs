using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class QueueTicket
    {

        // Cola para clientes regulares en compra de boletos
        //linked-list de Tickets 


        public Node head; // Primer elemento (frente de la cola)


        public QueueTicket()
        {
            head = null;
        }

        // Método para agregar un ticket a la cola
        public void Enqueue(Ticket_Cine ticket)
        {
            Node current = head;
            Node newNode = new Node(ticket);

            if (head == null) // Si la cola está vacía
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;

            }
        }


        public string Dequeue()
        {
            Node current = head;
            string Ticket = ""; 
            if (head == null) // Si la cola está vacía
            {
                MessageBox.Show("La cola está vacía.");
                Ticket = "";
                return Ticket;
            }
            while(current.Next != null)
            {
                current.Next = head.Next; // Guardar el ticket del nodo en el frente
                head = head.Next;               // Mover el frente al siguiente nodo
            }

            return Ticket;
        }


        public string Peek() 
        {
            string Ticket = "";
            if (head == null)
            {
                MessageBox.Show("La cola esta vacia, nadie esta en espera");
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
