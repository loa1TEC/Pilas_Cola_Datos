using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_Cola_Datos
{
    public class ArrayStack
    {
        private int[] stack;
        private int top;
        private int size;

        public ArrayStack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }

        public void Push(int element)
        {
            if (top == size - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            stack[++top] = element;
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            return stack[top--];
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            return stack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == size - 1;
        }
    }
}
