using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Cola_Datos
{
    public class LinkedListQueue
    {
        private Node front;
        private Node rear;

        public LinkedListQueue()
        {
            front = null;
            rear = null;
        }

        public void Enqueue(int element)
        {
            Node newNode = new Node(element);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }

            int element = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return element;
        }

        public int Front()
        {
            if (front == null)
            {
                Console.WriteLine("Queue Underflow");
                return -1;
            }
            return front.Data;
        }

        private class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }
    }
}
