using System.Windows.Forms;

namespace Cine_Pilas_Colas_
{
    public partial class Form1 : Form
    {
        int NumberAcent = 0;
        string Seat = "";

        public Form1()
        {

            InitializeComponent();
        }
        QueueTicket ticketQueue = new QueueTicket();
        PriorityTicketQueue TicketPriority = new PriorityTicketQueue();

        // M�todo que pregunta si el cliente tiene membres�a premium
        public bool Question()
        {
            DialogResult result = MessageBox.Show("�Tienes membres�a premium?", "Pregunta", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        // M�todo para el bot�n BtnA1
        private void BtnA1_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA1.Enabled = false;
            BtnA1.BackgroundImage = null;
            BtnA1.BackColor = System.Drawing.Color.Gray;
            Seat = "A1";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                // Si es premium, actualizar la propiedad y agregar a la cola de prioridad
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                // Si no es premium, agregar a la cola regular
                ticketQueue.Enqueue(ticket);
            }
        }


        private void BtnA2_Click_1(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA2.Enabled = false;
            BtnA2.BackgroundImage = null;
            BtnA2.BackColor = System.Drawing.Color.Gray;
            Seat = "A2";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }


        private void BtnA3_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA3.Enabled = false;
            BtnA3.BackgroundImage = null;
            BtnA3.BackColor = System.Drawing.Color.Gray;
            Seat = "A3";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA4.Enabled = false;
            BtnA4.BackgroundImage = null;
            BtnA4.BackColor = System.Drawing.Color.Gray;
            Seat = "A4";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA5.Enabled = false;
            BtnA5.BackgroundImage = null;
            BtnA5.BackColor = System.Drawing.Color.Gray;
            Seat = "A5";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnB1.Enabled = false;
            BtnB1.BackgroundImage = null;
            BtnB1.BackColor = System.Drawing.Color.Gray;
            Seat = "B1";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnB2.Enabled = false;
            BtnB2.BackgroundImage = null;
            BtnB2.BackColor = System.Drawing.Color.Gray;
            Seat = "B2";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnB3.Enabled = false;
            BtnB3.BackgroundImage = null;
            BtnB3.BackColor = System.Drawing.Color.Gray;
            Seat = "B3";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnB4.Enabled = false;
            BtnB4.BackgroundImage = null;
            BtnB4.BackColor = System.Drawing.Color.Gray;
            Seat = "B4";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnB5_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnB5.Enabled = false;
            BtnB5.BackgroundImage = null;
            BtnB5.BackColor = System.Drawing.Color.Gray;
            Seat = "B5";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnC1.Enabled = false;
            BtnC1.BackgroundImage = null;
            BtnC1.BackColor = System.Drawing.Color.Gray;
            Seat = "C1";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnC2.Enabled = false;
            BtnC2.BackgroundImage = null;
            BtnC2.BackColor = System.Drawing.Color.Gray;
            Seat = "C2";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnC3.Enabled = false;
            BtnC3.BackgroundImage = null;
            BtnC3.BackColor = System.Drawing.Color.Gray;
            Seat = "C3";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnC4.Enabled = false;
            BtnC4.BackgroundImage = null;
            BtnC4.BackColor = System.Drawing.Color.Gray;
            Seat = "C4";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnC5_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnC5.Enabled = false;
            BtnC5.BackgroundImage = null;
            BtnC5.BackColor = System.Drawing.Color.Gray;
            Seat = "C5";

            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                TicketPriority.Enqueue(ticket);
            }
            else
            {
                ticketQueue.Enqueue(ticket);
            }
        }

        private void BtnPopCorn_Click(object sender, EventArgs e)
        {




        }

        private void BtnMostrarColas_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"Ticket en espera: {ticketQueue.Peek()}"); // Ajusta seg�n tus propiedades
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message); // Muestra un mensaje si la cola est� vac�a
            }
        }

        private void BtnVIP_Click(object sender, EventArgs e)
        {

        }

        private void BtnCasual_Click(object sender, EventArgs e)
        {
            if (ticketQueue.IsEmpty() == true)
            {
                MessageBox.Show("No hay nadie en la cola para la dulceria");
            }
            else
            {
                MessageBox.Show("Turno del tiket " + ticketQueue.Peek());
                Lblshift.Text = ticketQueue.Dequeue();
                TabContrleCinema.SelectedIndex = 2;
            }


        }

        private void BtnOkey_Click(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En la cola Prioridad hay " + TicketPriority.Size().ToString() + " en fila");
            MessageBox.Show("En la cola hay " + ticketQueue.Size().ToString() + " en la fila");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Lblshift.Text = ticketQueue.Dequeue();
        }
    }
}
