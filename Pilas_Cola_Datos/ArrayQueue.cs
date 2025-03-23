using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Cola_Datos
{
    public class ArrayQueue
    {
        private int[] queue;
        private int front;
        private int rear;
        private int size;

        public ArrayQueue(int size)
        {
            this.size = size;
            queue = new int[size];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int element)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue Overflow");
            }
            else
            {
                if (front == -1)
                    front = 0;

                queue[++rear] = element;
            }
        }

        public int Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            else
            {
                int element = queue[front];
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front++;
                }
                return element;
            }
        }

        public int Front()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            return queue[front];
        }

        public bool IsEmpty()
        {
            return front == -1;
        }



    }
}
