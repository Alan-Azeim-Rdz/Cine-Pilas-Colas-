using System;
using System.Collections;
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
    public partial class Static_Stack : Form
    {
        public Static_Stack()
        {
            InitializeComponent();
        }

        private StaticStackClass stack = new StaticStackClass();
        private void btnPush_Click(object sender, EventArgs e)
        {

            try
            {
                int number = Convert.ToInt32(txtInput.Text);
                stack.Push(number);
                ActualizarPila();
                txtInput.Clear();
            }
            catch
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }

        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Pop());
            ActualizarPila();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elemento en el tope: " + stack.Peek());
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamaño actual de la pila: " + stack.Size());
        }

        private void ActualizarPila()
        {
            lstStack.Items.Clear();
            StaticStackClass temporal = new StaticStackClass();
            string elemento;

            // Mostrar los elementos en la pila
            while (!stack.IsEmpty())
            {
                elemento = stack.Pop();
                lstStack.Items.Add(elemento);
                temporal.Push(int.Parse(elemento));
            }

            // Restaurar los elementos en la pila original
            while (!temporal.IsEmpty())
            {
                stack.Push(int.Parse(temporal.Pop()));
            }
        }


    }
}
