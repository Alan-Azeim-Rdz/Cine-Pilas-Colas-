using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cine_Pilas_Colas_
{
    internal class QueueEstaticSale
    {
        public int count;
        public Ticket_Cine[] ticket_sale;

        public QueueEstaticSale()
        {
            count = 0;
            ticket_sale = new Ticket_Cine[5];
        }

        public bool IsEmpty() 
        {  
            return count == 0;
        }

        public bool IsFull() 
        { 
            return count == ticket_sale.Length; 
        }

        public void Enqueue(Ticket_Cine ticketSale)
        {
            if (IsFull())
            {
                MessageBox.Show("ya no hay boletos que califiquen al descuento");
                return;
            }
            ticket_sale[count] = ticketSale;

            count++;
            return;

        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string ticket = ticket_sale[0].ToString();

            // Desplazar los elementos restantes hacia la izquierda
            for (int i = 0; i < count; i++)
            {
                ticket_sale[i] = ticket_sale[i + 1];
            }

            count--;
            return ticket;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string ticket = ticket_sale[0].ToString();

            // Devolver el ticket en la posición del frente sin eliminarlo
            return ticket;
        }

        public int Size()
        {
            return ticket_sale.Length;
        }



    }
}
