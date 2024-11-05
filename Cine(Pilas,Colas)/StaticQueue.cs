using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine_Pilas_Colas_
{
    internal class StaticQueue
    {
        int head;
        int count;
        public int?[] data_number;


        public StaticQueue()
        {
            head = 0;
            count = 0;
            data_number = new int?[5];
        }


        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == data_number.Length;
        }

        public void Enqueue(int Number)
        {
            if (!IsFull())
            {
                data_number[count] = Number;
                count++;
                return;
            }

            return;

        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInHead = data_number[0].ToString();

            // Desplazar los elementos restantes hacia la izquierda
            for (int i = 0; i < count - 1;)
            {
                data_number[i] = data_number[i + 1];
                i++;
            }

            count--;
            data_number[count] = null;

            return numberInHead;
        }

        public int Size()
        {

            return count;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInTheHead = data_number[0].ToString();
            return numberInTheHead;
        }


    }
}
