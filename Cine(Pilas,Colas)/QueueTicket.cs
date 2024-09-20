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
        private Queue<Ticket_Cine> colaClientesBoleto = new Queue<Ticket_Cine>();

        // Cola de prioridad para clientes premium (atendidos antes)
        private SortedList<int, Ticket_Cine> colaClientesPremium = new SortedList<int, Ticket_Cine>(); // SortedList simula prioridad

        private int contadorPremium = 0; // Para manejo de prioridad


        public void ComprarBoleto(Ticket_Cine ticket)
        {
            if (ticket.IsPremium.ToString() == "si")
            {
                colaClientesPremium.Add(contadorPremium++, ticket); // Clientes premium con prioridad
            }
            else
            {
                colaClientesBoleto.Enqueue(ticket); // Clientes regulares
            }
        }

        public void AtenderClienteBoleto()
        {
            if (colaClientesPremium.Count > 0)
            {
                var cliente = colaClientesPremium.Values[0];
                colaClientesPremium.RemoveAt(0);
                MessageBox.Show($"Atendiendo cliente premium: {cliente}");
            }
            else if (colaClientesBoleto.Count > 0)
            {
                var cliente = colaClientesBoleto.Dequeue();
                MessageBox.Show($"Atendiendo cliente regular: {cliente}");
            }
            else
            {
                MessageBox.Show("No hay clientes en la cola de boletos.");
            }
        }

        // Método para mostrar los datos de ambas colas
        public string ObtenerDatosColas()
        {
            StringBuilder datos = new StringBuilder();

            // Mostrar clientes premium primero
            datos.AppendLine("Clientes Premium:");
            foreach (var cliente in colaClientesPremium.Values)
            {
                datos.AppendLine(cliente.ToString());
            }

            // Mostrar clientes regulares
            datos.AppendLine("\nClientes Regulares:");
            foreach (var cliente in colaClientesBoleto)
            {
                datos.AppendLine(cliente.ToString());
            }

            return datos.ToString();
        }
    }
}
