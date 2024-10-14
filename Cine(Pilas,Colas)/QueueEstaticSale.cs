using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class QueueEstaticSale
    {
        public int count;
        public Ticket_Cine[] ticket_sale;

        public QueueEstaticSale()
        {
            count = 0;
            ticket_sale = new Ticket_Cine[1];
        }

        public bool IsEmpty() 
        {  
            return count == 0; ;
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
            if (IsEmpty())
            {
                ticket_sale[count] = ticketSale;
              
            }
            count++;
            return;

        }


    }
}
