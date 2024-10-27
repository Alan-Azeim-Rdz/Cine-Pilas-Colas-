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

        public void Enqueue(Node newNode)
        {

            if (IsEmpty()) 
            {
                head = newNode; 
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            return ;
        }


        public Node Dequeue()
        {
            if (!IsEmpty())
            {
                Node dequeuedNode = head;
                head = head.Next;
                dequeuedNode.Next = null; // Desconectar el nodo desencolado
                return dequeuedNode;
            }
            return null; // Si la cola está vacía
        }


       // Obtener el nodo en el frente sin desencolarlo
        public Node Peek() 
        {
            if (!IsEmpty())
            {
                return head;
            }
            return null; // Si la cola está vacía
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
