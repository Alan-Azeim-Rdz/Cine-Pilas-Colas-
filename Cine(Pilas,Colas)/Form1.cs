using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Cine_Pilas_Colas_
{
    public partial class Form1 : Form
    {
        int number_acent = 0;
        string seat = "";

        public Form1()
        {

            InitializeComponent();
        }
        QueueTicket ticketqueue = new QueueTicket();
        QueueTicket ticketqueue_p = new QueueTicket();
        QueueTicket tickets = new QueueTicket();
        Ticket_Cine ticket = new Ticket_Cine();

        // M�todo que pregunta si el cliente tiene membres�a premium
        public bool Question()
        {
            DialogResult result = MessageBox.Show("�Tienes membres�a premium?", "Pregunta", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }


        //cinema seats

        private void BtnA1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA1.Enabled = false;
            BtnA1.BackgroundImage = null;
            BtnA1.BackColor = System.Drawing.Color.Gray;
            seat = "A1";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }


        private void BtnA2_Click_1(object sender, EventArgs e)
        {
            number_acent++;
            BtnA2.Enabled = false;
            BtnA2.BackgroundImage = null;
            BtnA2.BackColor = System.Drawing.Color.Gray;
            seat = "A2";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }


        private void BtnA3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA3.Enabled = false;
            BtnA3.BackgroundImage = null;
            BtnA3.BackColor = System.Drawing.Color.Gray;
            seat = "A3";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA4.Enabled = false;
            BtnA4.BackgroundImage = null;
            BtnA4.BackColor = System.Drawing.Color.Gray;
            seat = "A4";


            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA5.Enabled = false;
            BtnA5.BackgroundImage = null;
            BtnA5.BackColor = System.Drawing.Color.Gray;
            seat = "A5";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB1.Enabled = false;
            BtnB1.BackgroundImage = null;
            BtnB1.BackColor = System.Drawing.Color.Gray;
            seat = "B1";


            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB2.Enabled = false;
            BtnB2.BackgroundImage = null;
            BtnB2.BackColor = System.Drawing.Color.Gray;
            seat = "B2";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB3.Enabled = false;
            BtnB3.BackgroundImage = null;
            BtnB3.BackColor = System.Drawing.Color.Gray;
            seat = "B3";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB4.Enabled = false;
            BtnB4.BackgroundImage = null;
            BtnB4.BackColor = System.Drawing.Color.Gray;
            seat = "B4";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnB5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB5.Enabled = false;
            BtnB5.BackgroundImage = null;
            BtnB5.BackColor = System.Drawing.Color.Gray;
            seat = "B5";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC1.Enabled = false;
            BtnC1.BackgroundImage = null;
            BtnC1.BackColor = System.Drawing.Color.Gray;
            seat = "C1";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC2.Enabled = false;
            BtnC2.BackgroundImage = null;
            BtnC2.BackColor = System.Drawing.Color.Gray;
            seat = "C2";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC3.Enabled = false;
            BtnC3.BackgroundImage = null;
            BtnC3.BackColor = System.Drawing.Color.Gray;
            seat = "C3";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC4.Enabled = false;
            BtnC4.BackgroundImage = null;
            BtnC4.BackColor = System.Drawing.Color.Gray;
            seat = "C4";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }

        private void BtnC5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC5.Enabled = false;
            BtnC5.BackgroundImage = null;
            BtnC5.BackColor = System.Drawing.Color.Gray;
            seat = "C5";

            // Crear el ticket
            ProcessTicket(number_acent, seat);
        }


        private void BtnMostrarColas_Click(object sender, EventArgs e)
        {
            if (!ticketqueue_p.IsEmpty() == false)
            {
                TabContrleCinema.SelectedIndex = 1;
                Lblshift.Text = ticketqueue.Dequeue();
                return;
            }

            TabContrleCinema.SelectedIndex = 1;
            Lblshift.Text = ticketqueue_p.Dequeue();
            return;

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Primero, verificamos si la cola premium NO est� vac�a
            if (!ticketqueue_p.IsEmpty())
            {
                Lblshift.Text = ticketqueue_p.Dequeue(); //   Si tiene elementos, se hace Dequeue
                return;
            }
            // Si la cola premium est� vac�a, verificamos la cola regular
            if (!ticketqueue.IsEmpty())
            {
                Lblshift.Text = ticketqueue.Dequeue(); // Si la cola regular tiene elementos, se hace Dequeue
                return;
            }
            // Si ambas colas est�n vac�as, mostramos un mensaje
            Lblshift.Text = "No hay m�s clientes \n en espera.";
        }

        public void ProcessTicket(int numberAcent, string seat)
        {
            // Crear el ticket del cine
            Ticket_Cine ticket = new Ticket_Cine(numberAcent, seat, "");

            // Llamar al m�todo Question para determinar si es premium
            if (Question())
            {
                // Si es premium, actualizar la propiedad y agregar a la cola de prioridad
                ticket.IsPremium = "si";
                ticketqueue_p.Enqueue(ticket);
                MessageBox.Show(ticket.ToString());
                return;
            }
            // Si no es premium, agregar a la cola regular
            ticket.IsPremium = "no";
            ticketqueue.Enqueue(ticket);
            MessageBox.Show(ticket.ToString());

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (!ticketqueue_p.IsEmpty()) 
            {
                MessageBox.Show(ticketqueue_p.Peek());
                return;
            }
            if (!ticketqueue.IsEmpty())
            {
                MessageBox.Show(ticketqueue.Peek());
                return;
            }

            MessageBox.Show("No hay nadie en espera");

        }

    }
}
