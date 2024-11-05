using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Pilas_Colas_
{
    public partial class QueueStatic : Form
    {
        public QueueStatic()
        {
            InitializeComponent();
        }

        StaticQueue queueNumbers = new StaticQueue();
        StaticQueue queueNumbers_Priority = new StaticQueue();


        private void BtnEnqueue_Click(object sender, EventArgs e)
        {


            try
            {
                int number = Convert.ToInt32(TxtNumberAdd.Text);
                if (number % 2 == 0)
                {
                    if (!queueNumbers_Priority.IsFull())
                    {
                        queueNumbers_Priority.Enqueue(number);
                        TxtNumberAdd.Clear();
                        LisboxPriority.Items.Add(number.ToString());
                        return;
                    }
                }
                if (number % 2 != 0)
                {
                    if (!queueNumbers.IsFull())
                    {
                        queueNumbers.Enqueue(number);
                        TxtNumberAdd.Clear();
                        LisBxDataNumber.Items.Add(number.ToString());
                        return;
                    }
                }
                MessageBox.Show("La cola esta llena, si quieres introducir mas datos borra alugnos con el boton remove");
                TxtNumberAdd.Clear();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("No puedes ingresar letras, porfavor ingresa un numero");
                TxtNumberAdd.Clear();
            }

        }

        private void BtnDequeue_Click(object sender, EventArgs e)
        {
            if (!queueNumbers_Priority.IsEmpty())
            {
                MessageBox.Show(queueNumbers_Priority.Dequeue());
                LisboxPriority.Items.RemoveAt(0);
                return;
            }
            if (!queueNumbers.IsEmpty())
            {
                MessageBox.Show(queueNumbers.Dequeue());
                LisBxDataNumber.Items.RemoveAt(0); // Remueve el primer elemento de la ListView
                return;
            }
            MessageBox.Show("No hay datos para sacar");
        }


        private void BtnPeek_Click(object sender, EventArgs e)
        {
            if (!(queueNumbers_Priority.IsEmpty()))
            {
                MessageBox.Show(queueNumbers_Priority.Peek());
                return;
            }

            if (!(queueNumbers.IsEmpty()))
            {
                MessageBox.Show(queueNumbers.Peek());
                return;
            }

            MessageBox.Show("No existen datos por mostrar");


        }

        private void BtnSizeIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en la cola normal hay " + queueNumbers.Size().ToString() + " espacios ocupados en la cola estatica de 5");
        }

        private void BtnSizeP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("en la cola prioridad hay " + queueNumbers_Priority.Size().ToString() + " espacios ocupados en la cola estatica de 5");
        }


    }
}
