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

        // Método que pregunta si el cliente tiene membresía premium
        public bool Question()
        {
            DialogResult result = MessageBox.Show("¿Tienes membresía premium?", "Pregunta", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        // Método para el botón BtnA1
        private void BtnA1_Click(object sender, EventArgs e)
        {
            NumberAcent++;
            BtnA1.Enabled = false;
            BtnA1.BackgroundImage = null;
            BtnA1.BackColor = System.Drawing.Color.Gray;
            Seat = "A1";

            // Crear el ticket
            Ticket_Cine ticket = new Ticket_Cine(NumberAcent, Seat, "");

            // Llamar al método Question para determinar si es premium
            if (Question())
            {
                // Si es premium, actualizar la propiedad y agregar a la cola de prioridad
                ticket.IsPremium = "si";
                ticketQueue.ComprarBoleto(ticket);
            }
            else
            {
                // Si no es premium, agregar a la cola regular
                ticketQueue.ComprarBoleto(ticket);
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

            // Llamar al método Question para determinar si es premium
            if (Question())
            {
                ticket.IsPremium = "si";
                ticketQueue.ComprarBoleto(ticket);
            }
            else
            {
                ticketQueue.ComprarBoleto(ticket);
            }
        }

        private void BtnMostrarColas_Click(object sender, EventArgs e)
        {
            // Mostrar los datos de las colas
            string datos = ticketQueue.ObtenerDatosColas();
            MessageBox.Show(datos, "Datos de las Colas");
        }
    }
}
