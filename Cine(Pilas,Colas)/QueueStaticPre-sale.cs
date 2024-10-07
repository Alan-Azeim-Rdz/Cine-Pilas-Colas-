using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class QueueStaticPre_sale
    {
        public class Queue
        {
            private Ticket_Cine[] PreSale;   // Arreglo para almacenar los elementos de la cola
            private int count;     // Número de elementos en la cola

            // Constructor para inicializar la cola
            public Queue()
            {
                PreSale = new Ticket_Cine[5];
                count = 0;  // La cola está vacía
            }

            // Método para agregar un elemento a la cola (enqueue)
            public void Enqueue(Ticket_Cine item)
            {
                if (IsFull())
                {
                    MessageBox.Show("Lo siento ya no hay ma boletos disponibles para la pre-compra");
                    return;
                }

                // Agregar el elemento al final de la cola (en la posición `count`)
                PreSale[count] = item;
                count++;  // Incrementar el número de elementos
                return;
            }

            // Método para eliminar y devolver el elemento del frente de la cola (dequeue)
            public string Dequeue()
            {
                string ticket = "";
                if (IsEmpty())
                {
                    ticket = "No hay tickets para eliminar";
                    return ticket; // Devuelve un valor indicativo de error, o puede lanzar una excepción
                }

                // Guardar el primer elemento en una variable
                Ticket_Cine item = PreSale[0];

                // Mover todos los elementos hacia adelante
                for (int i = 1; i < count; i++)
                {
                    PreSale[i - 1] = PreSale[i];
                }

                count--; // Disminuir el contador de elementos
                return item.ToString();
            }

            // Método para verificar si la cola está llena
            public bool IsFull()
            {
                return Convert.ToBoolean( count = PreSale.Length);
            }

            // Método para verificar si la cola está vacía
            public bool IsEmpty()
            {
                return count == 0;
            }

            // Método para obtener el elemento en el frente de la cola sin eliminarlo
            public string Peek()
            {
                string ticket;
                if (IsEmpty())
                {
                    ticket = "No han comprado Tickets";
                    return ticket;
                }

                ticket = PreSale[0].ToString();

                return ticket;
            }
        }



    }
}
