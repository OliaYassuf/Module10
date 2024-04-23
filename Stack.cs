using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Stack<T>
    {
        private class Node
        {
            public T Data { get; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;
        private int count;

        public Stack()
        {
            top = null;
            count = 0;
        }

        public void Push(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return top.Data;
        }

        public int Count
        {
            get { return count; }
        }
    }
}
