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

        public void Q



    }
}
