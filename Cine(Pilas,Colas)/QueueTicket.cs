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


        private Node front; // Primer elemento (frente de la cola)
        private Node rear;  // Último elemento (final de la cola)

        public QueueTicket()
        {
            front = null;
            rear = null;
        }

        // Método para agregar un ticket a la cola
        public void Enqueue(Ticket_Cine ticket)
        {
            Node newNode = new Node(ticket);

            if (rear == null) // Si la cola está vacía
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode; // El nodo actual al final apunta al nuevo nodo
                rear = newNode;      // El nuevo nodo se convierte en el último
            }
        }

        public string Dequeue()
        {
            string Ticket = ""; 
            if (front == null) // Si la cola está vacía
            {
                MessageBox.Show("La cola está vacía.");
                Ticket = "";
                return Ticket;
            }

            Ticket_Cine ticket = front.Ticket; // Guardar el ticket del nodo en el frente
            front = front.Next;                // Mover el frente al siguiente nodo

            if (front == null) // Si la cola ahora está vacía, rear también debe ser null
            {
                rear = null;
            }
            
            Ticket = ticket.ToString();

            return Ticket;
        }


        public string Peek() 
        {
            if(front == null)
            {
                throw new InvalidOperationException("La cola esta vacia, nadie esta en espera");
            }

             string Ticket = "\n" + front.Ticket.ToString();
            return Ticket;
        }

        public bool IsEmpty() => front == null;

        public int Size()
        {
            int count = 0;
            Node current = front;

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
