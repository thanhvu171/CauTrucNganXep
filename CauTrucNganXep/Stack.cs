using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucNganXep
{
    class Stack
    {
        private int[] data;
        private int top;

        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public bool isEmpty()
        {
            bool kq = false;
            if (top == - 1)
            {
                kq = true;
            }
            return kq;
        }
        public bool isFull()
        {
            bool kq = false;
            if (top == data.Length - 1) 
            {
                kq = true;
            }
            return kq;
        }
        public void push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack da day. Them that bai!");
            }
            else
            {
                top++;
                data[top] = x;
            }
        }
        public int pop()
        {
            int kq = 0;
            if (isEmpty())
            {
                Console.WriteLine("Stack da day. Them that bai!");
            }
            else
            {
                kq = data[top];
                top--;
            }
            return kq;
        }
    }
}
