using Estructura_de_datos_Pilas_y_Colas;
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
    public partial class Stack_Dinamic : Form
    {
        public Stack_Dinamic()
        {
            InitializeComponent();
        }
        DinamicStack miPila = new DinamicStack();

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                NodeStack newNode = new NodeStack(Convert.ToInt32(txtData.Text));
                miPila.Push(newNode);
                UpdateStack();
                txtData.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {

            if (!miPila.IsEmpty())
            {
                NodeStack poppedNode = miPila.Pop();
                UpdateStack();
                MessageBox.Show("Elemento eliminado: " + poppedNode.Data);
                return;
            }
            UpdateStack();
            MessageBox.Show("La pila está vacía.");
            return;

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            NodeStack topNode = miPila.Peek();
            if (!miPila.IsEmpty())
            {
                MessageBox.Show("Elemento en el top: " + topNode.Data);
                return;
            }
            MessageBox.Show("La pila está vacía.");
            return;
        }



        private void UpdateStack()
        {
            lstPila.Items.Clear(); // Limpia la lista antes de actualizar
            NodeStack currentNode = miPila.Peek(); // Asegúrate de que esto esté correctamente referenciado

            while (currentNode != null)
            {
                lstPila.Items.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hay " + miPila.Size() + " elementos en la pila");
        }
    }
}
