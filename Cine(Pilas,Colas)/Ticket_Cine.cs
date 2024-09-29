using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class Ticket_Cine
    {
        // Propiedades para el número del ticket y el nombre del cliente
        public int NumeroTicket { get; set; }
        public string Seat { get; set; }
        public string IsPremium { get; set; } // Flag para cliente premium


        // Constructor para inicializar el ticket
        public Ticket_Cine(int numeroTicket, string seat, string isPremium)
        {
            NumeroTicket = numeroTicket;
            Seat = seat;
            IsPremium = isPremium;
        }

        // Método para mostrar información del ticket
        public override string ToString()
        {
            return "Numero = " + NumeroTicket + "\n Aciento = " + Seat + "\n Es Premium = " + IsPremium;
        }



    }
}
