using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Cola_Datos
{
    public class LinkedListStack
    {
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

        private Node top;

        public LinkedListStack()
        {
            top = null;
        }

        public void Push(int element)
        {
            Node newNode = new Node(element);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            int element = top.Data;
            top = top.Next;
            return element;
        }

        public int Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

}
