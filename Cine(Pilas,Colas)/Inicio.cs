using Estructura_de_datos_Pilas_y_Colas;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnGoDinamicQueue_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnGoEstaticQueue_Click(object sender, EventArgs e)
        {
            QueueStatic Static_Queue = new QueueStatic();
            Static_Queue.Show();
            this.Hide();
        }

        private void BtnGoEstaticStack_Click(object sender, EventArgs e)
        {
            Static_Stack Static_Stack = new Static_Stack();
            Static_Stack.Show();
            this.Hide();
        }

        private void BtnGoDinamicStack_Click(object sender, EventArgs e)
        {
            Stack_Dinamic stack_Dinamic = new Stack_Dinamic();
            stack_Dinamic.Show();
            this.Hide();
        }

        private void BtnGoDinamicQueueDouble_Click(object sender, EventArgs e)
        {

        }

        private void BtnGoEstaticQueueDouble_Click(object sender, EventArgs e)
        {

        }
    }
}
