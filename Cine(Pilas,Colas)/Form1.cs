using Cine_Pilas_Colas_;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Estructura_de_datos_Pilas_y_Colas
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        int number_acent = 0;
        string seat = "";
        QueueTicket ticketqueue = new QueueTicket();
        QueueTicket ticketqueue_p = new QueueTicket();


        //cinema seats

        private void BtnA1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA1.Enabled = false;
            BtnA1.BackgroundImage = null;
            BtnA1.BackColor = System.Drawing.Color.Gray;
            seat = "A1";
            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);

        }


        private void BtnA2_Click_1(object sender, EventArgs e)
        {
            number_acent++;
            BtnA2.Enabled = false;
            BtnA2.BackgroundImage = null;
            BtnA2.BackColor = System.Drawing.Color.Gray;
            seat = "A2";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }


        private void BtnA3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA3.Enabled = false;
            BtnA3.BackgroundImage = null;
            BtnA3.BackColor = System.Drawing.Color.Gray;
            seat = "A3";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA4.Enabled = false;
            BtnA4.BackgroundImage = null;
            BtnA4.BackColor = System.Drawing.Color.Gray;
            seat = "A4";


            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnA5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnA5.Enabled = false;
            BtnA5.BackgroundImage = null;
            BtnA5.BackColor = System.Drawing.Color.Gray;
            seat = "A5";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnB1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB1.Enabled = false;
            BtnB1.BackgroundImage = null;
            BtnB1.BackColor = System.Drawing.Color.Gray;
            seat = "B1";


            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnB2_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB2.Enabled = false;
            BtnB2.BackgroundImage = null;
            BtnB2.BackColor = System.Drawing.Color.Gray;
            seat = "B2";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnB3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB3.Enabled = false;
            BtnB3.BackgroundImage = null;
            BtnB3.BackColor = System.Drawing.Color.Gray;
            seat = "B3";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB4.Enabled = false;
            BtnB4.BackgroundImage = null;
            BtnB4.BackColor = System.Drawing.Color.Gray;
            seat = "B4";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnB5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnB5.Enabled = false;
            BtnB5.BackgroundImage = null;
            BtnB5.BackColor = System.Drawing.Color.Gray;
            seat = "B5";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            Node node = new Node(ticket);
            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC1.Enabled = false;
            BtnC1.BackgroundImage = null;
            BtnC1.BackColor = System.Drawing.Color.Gray;
            seat = "C1";


            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnC2_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC2.Enabled = false;
            BtnC2.BackgroundImage = null;
            BtnC2.BackColor = System.Drawing.Color.Gray;
            seat = "C2";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC3.Enabled = false;
            BtnC3.BackgroundImage = null;
            BtnC3.BackColor = System.Drawing.Color.Gray;
            seat = "C3";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC4.Enabled = false;
            BtnC4.BackgroundImage = null;
            BtnC4.BackColor = System.Drawing.Color.Gray;
            seat = "C4";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnC5_Click(object sender, EventArgs e)
        {
            number_acent++;
            BtnC5.Enabled = false;
            BtnC5.BackgroundImage = null;
            BtnC5.BackColor = System.Drawing.Color.Gray;
            seat = "C5";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(number_acent, seat, "");
            Node node = new Node(ticket);
            // Verificar el estado del botón VIP y asignar si es premium o no
            CheckVip(ticket);

            // Agregar el ticket a la cola correspondiente
            ProcessTicket(node);
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            // Primero verifica si hay elementos en la cola de prioridad
            if (!ticketqueue_p.IsEmpty())
            {
                TabContrleCinema.SelectedIndex = 1;
                // Desencola de la cola de prioridad y muestra el elemento
                Lblshift.Text = ticketqueue_p.Dequeue().ToString();
                return;
            }

            TabContrleCinema.SelectedIndex = 1;
            // Desencola de la cola normal y muestra el elemento
            Lblshift.Text = ticketqueue.Dequeue().ToString();
            return;
        }


        private void BtnQuestionForNex_Click(object sender, EventArgs e)
        {
            if (!ticketqueue_p.IsEmpty())
            {
                MessageBox.Show(ticketqueue_p.Peek().ToString());
                return;
            }
            if (!ticketqueue.IsEmpty())
            {
                MessageBox.Show(ticketqueue.Peek().ToString());
                return;
            }

            MessageBox.Show("No hay nadie en espera");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // Primero, verificamos si la cola premium NO está vacía
            if (!ticketqueue_p.IsEmpty())
            {
                Lblshift.Text = ticketqueue_p.Dequeue().ToString(); //   Si tiene elementos, se hace Dequeue
                return;
            }
            // Si la cola premium está vacía, verificamos la cola regular
            if (!ticketqueue.IsEmpty())
            {
                Lblshift.Text = ticketqueue.Dequeue().ToString(); // Si la cola regular tiene elementos, se hace Dequeue
                return;
            }
            // Si ambas colas están vacías, mostramos un mensaje
            Lblshift.Text = "No hay más clientes \n en espera.";
        }


        private void ProcessTicket(Node node)
        {

            if (node.Ticket.IsPremium == "si")
            {
                ticketqueue_p.Enqueue(node);
                MessageBox.Show(node.ToString());
                BtnVIP.Enabled = true;
                return;

            }
            ticketqueue.Enqueue(node);
            MessageBox.Show(node.ToString());
            BtnVIP.Enabled = true;

        }





        private void BtnVIP_Click(object sender, EventArgs e)
        {
            BtnVIP.Enabled = false;
        }

        private void CheckVip(Ticket_Cine ticket)
        {
            // Verifica si el botón VIP está activo (Enabled = true) o desactivado (Enabled = false)
            if (BtnVIP.Enabled)
            {
                ticket.IsPremium = "no"; // Si está activo, no es premium
            }
            else
            {
                ticket.IsPremium = "si"; // Si está desactivado, es premium
            }
        }


        private void BtnPersonTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + ticketqueue.Size() + " esperando su turno");
        }

        private void BtnPersonTotalPriority_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + ticketqueue_p.Size() + " esperando su turno");
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
